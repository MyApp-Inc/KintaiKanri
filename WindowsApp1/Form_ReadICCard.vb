Imports Oracle.ManagedDataAccess.Client

Public Class Form_ReadICCard
    Dim Constr As String = "user id=pcs;password=pcs;data source=" +
                            "  (DESCRIPTION =" +
                            "      (ADDRESS_LIST =" +
                            "        (ADDRESS = (PROTOCOL = TCP)(HOST = cl-oda-scn-b)(PORT = 1521))" +
                            "      )" +
                            "      (CONNECT_DATA =" +
                            "        (SERVER = DEDICATED)" +
                            "        (SERVICE_NAME = dev1)" +
                            "      )" +
                            "    )" +
                            ";Pooling=false"
    Dim DBName As String = SystemInformation.UserName
    Dim Today As String = Date.Now.ToString("yyyy/MM/dd")
    Dim CardID As String = "0"

    ' clsWinSCardクラスに関して
    ' (1) Timeout_MilliSecond にタイムアウトする時間(ミリ秒)を設定する
    '     設定しなければ、Pasoriにカードがセットされるまで無限に待機する
    ' (2) getCardID() を実行することで、下記のプロパティを読み取れるようになります
    '     CardType … カードの種類
    '     IsFelica … Felicaの場合、True
    '     IDm      … FelicaのIDm
    '     PMm      … FelicaのPMm
    '     IsMifare … Mifareの場合、True
    '     UID      … MifareのUID

    '======================
    ' ボタン・クリック処理
    '======================
    Private Sub btnCardID_Click(sender As Object, e As System.EventArgs) Handles btnCardID.Click
        '----------
        ' 変数定義
        '----------
        Dim pcsc As New clsWinSCard
        Dim NowTime As String = "00:00"
        Dim UserName As String = ""
        Dim FullName As String = ""
        Dim CardFlg As Boolean = False

        'SqlConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLTimeCard As String = "SELECT * FROM tt_kintai_timecard"
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        'DataAdapterオブジェクトを生成
        Dim daTimeCard As New OracleDataAdapter(SQLTimeCard, con)
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        'SqlCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daTimeCard)
        'DataTableオブジェクトを生成
        Dim dtTimeCard As New DataTable()
        Dim dtUser As New DataTable()
        'DataTableとデータベースに同期させる
        daTimeCard.Fill(dtTimeCard)
        daUser.Fill(dtUser)

        '----------------
        ' ボタンを無効化
        '----------------
        btnCardID.Enabled = False

        '------------------------------
        ' タイムアウトする時間(ミリ秒)
        '------------------------------
        pcsc.Timeout_MilliSecond = 1000

        '------------------------------------
        ' FelicaのIDm,PMM、MifareのUIDを取得
        '------------------------------------
        If pcsc.getCardID() Then
            NowTime = Date.Now.ToString("yy/MM/dd HH:mm")
            If pcsc.IsFelica Then
                If pcsc.IDm <> CardID Then
                    CardID = pcsc.IDm
                    CardFlg = True
                Else
                    CardFlg = False
                End If
            ElseIf pcsc.IsMifare Then
                If pcsc.UID <> CardID Then
                    CardID = pcsc.UID
                    CardFlg = True
                Else
                    CardFlg = False
                End If
            End If
            If CardFlg Then
                'リッチテキストボックスにフォーカスを移動
                RichTextBox_ReadICCard.Focus()
                'CardIDからuser_nameとfull_name取得
                Dim drlistUser As DataRow() = dtUser.Select("iccard_cd = '" + CardID + "'")
                If drlistUser.Length > 0 Then
                    My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
                    For Each drUser As DataRow In drlistUser
                        UserName = drUser("user_name")
                        FullName = drUser("full_name")
                    Next
                    'user_nameからTimeCardテーブル検索し、出勤or退勤を判定
                    Dim drlistTimeCard As DataRow() = dtTimeCard.Select("user_id = '" + UserName + "' AND workingday = '" + Today + "'")
                    If drlistTimeCard.Length = 0 Then
                        '出勤：出勤メッセージ表示してTimeCardテーブルにデータ追加
                        RichTextBox_ReadICCard.AppendText(NowTime + "　【出勤】" + FullName + "さん、おはようございます！" + vbNewLine)
                        Dim row As DataRow = dtTimeCard.NewRow '追加行を宣言
                        '値をセット
                        row("id_no") = dtTimeCard.Rows.Count + 1
                        row("user_id") = UserName
                        row("workingday") = Today
                        row("start_time") = Date.Now
                        row("end_time") = Date.Now
                        row("create_date") = Date.Now
                        row("update_date") = Date.Now
                        row("create_program") = "KINTAI_KANRI_SYSTEM"
                        row("update_program") = "KINTAI_KANRI_SYSTEM"
                        row("create_user") = DBName
                        row("update_user") = DBName
                        'テーブルの末尾に追加
                        dtTimeCard.Rows.Add(row)
                        daTimeCard.Update(dtTimeCard)
                    Else
                        '退勤：退勤メッセージ表示してTimeCardテーブルのデータ編集
                        RichTextBox_ReadICCard.AppendText(NowTime + "　【退勤】" + FullName + "さん、お疲れ様でした！" + vbNewLine)
                        For Each dr As DataRow In drlistTimeCard
                            dr("end_time") = Date.Now
                            dr("update_date") = Date.Now
                            dr("update_program") = "KINTAI_KANRI_SYSTEM"
                            dr("update_user") = DBName
                            daTimeCard.Update(dtTimeCard)
                        Next
                    End If
                    con = Nothing
                Else
                    My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
                    RichTextBox_ReadICCard.AppendText(NowTime + "　【エラー】このカードは登録されていません。" + vbNewLine)
                End If
            End If
        Else
            Label_ReadICCardStatus.Text = "ＩＣカードをリーダーにタッチしてください"
            Label_ReadICCardStatus.ForeColor = Color.Blue
            CardID = Nothing
        End If

        '----------------
        ' ボタンを有効化
        '----------------
        btnCardID.Enabled = True

    End Sub

    Private Sub Button_PrintEnd_Click(sender As Object, e As EventArgs) Handles Button_PrintEnd.Click
        Me.Close()
    End Sub

    Private Sub Timer_ReadICCard_Tick(sender As Object, e As EventArgs) Handles Timer_ReadICCard.Tick
        btnCardID.PerformClick()
    End Sub

    Private Sub Form_ReadICCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCardID.PerformClick()
    End Sub
End Class
