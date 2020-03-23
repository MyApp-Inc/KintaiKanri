'*******************************************************************************************************
'       クラス名：clsWinSCard
' コンストラクタ：clsWinSCard()
'       メソッド：getCardID() As Boolean
'     プロパティ：Timeout_MilliSecond As Integer  タイムアウトする時間(ミリ秒)
'                 CardType            As String   カードの種類      (ReadOnly)
'                 IsFelica            As Boolean  Felicaフラグ      (ReadOnly)
'                 IsMifare            As Boolean  Mifeaフラグ       (ReadOnly)
'                 IDm                 As String   FelicaのIDm       (ReadOnly)
'                 PMm                 As String   FelicaのPMm       (ReadOnly)
'                 UID                 As String   MifareのUID       (ReadOnly)
'                 ErrorMsg            As String   エラーメッセージ  (ReadOnly)
'-------------------------------------------------------------------------------------------------------
' winscard.dllの機能を使ってFelicaのIDmやPMm、MifareのUIDを取得する
' 実行前に設定する項目   Timeout_MilliSecond ※設定しない場合、PaSoRiにカードをかざすまで無限に待機する
' 実行後に設定される項目 CardType, IsFelica, IsMifare, IDm, PMm, UID, ErrorMsg
'*******************************************************************************************************

'*********
' 参考URL
'*********
' ソフテックだより 第２０３号（2014年2月5日発行） 技術レポート「非接触ICカード技術"FeliCa(フェリカ)"のIDm読み取り方法」
' http://www.softech.co.jp/mm_140205_pc.htm
' VB.netでPC/SC(NFC通信)してFelicaやMifareを読み取るサンプル
' http://log.windows78.net/2015/03/1295/
' EternalWindows セキュリティ / スマートカード
' http://eternalwindows.jp/security/scard/scard00.html

'******
' MSDN
'******
' プラットフォーム呼び出しのデータ型
' https://msdn.microsoft.com/ja-jp/library/ac7ay120(v=vs.110).aspx
' SCardEstablishContext
' https://msdn.microsoft.com/ja-jp/library/windows/desktop/aa379479(v=vs.85).aspx
' SCardListReaders
' https://msdn.microsoft.com/ja-jp/library/windows/desktop/aa379793(v=vs.85).aspx
' SCardGetStatusChange
' https://msdn.microsoft.com/ja-jp/library/windows/desktop/aa379773(v=vs.85).aspx
' SCardConnect
' https://msdn.microsoft.com/ja-jp/library/windows/desktop/aa379473(v=vs.85).aspx
' SCardStatus
' https://msdn.microsoft.com/ja-jp/library/windows/desktop/aa379803(v=vs.85).aspx
' SCardTransmit
' https://msdn.microsoft.com/ja-jp/library/windows/desktop/aa379804(v=vs.85).aspx
' SCardDisconnect
' https://msdn.microsoft.com/ja-jp/library/windows/desktop/aa379475(v=vs.85).aspx
' SCardFreeMemory
' https://msdn.microsoft.com/ja-jp/library/windows/desktop/aa379488(v=vs.85).aspx
' SCardReleaseContext
' https://msdn.microsoft.com/ja-jp/library/windows/desktop/aa379798(v=vs.85).aspx

Imports System
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class clsWinSCard
    '==========
    ' 定数定義
    '==========
    Private Const SCARD_S_SUCCESS                 As Integer  = 0
    Private Const SCARD_F_INTERNAL_ERROR          As Integer  = &H80100001
    Private Const SCARD_E_CANCELLED               As Integer  = &H80100002
    Private Const SCARD_E_INVALID_HANDLE          As Integer  = &H80100003
    Private Const SCARD_E_INVALID_PARAMETER       As Integer  = &H80100004
    Private Const SCARD_E_INVALID_TARGET          As Integer  = &H80100005
    Private Const SCARD_E_NO_MEMORY               As Integer  = &H80100006
    Private Const SCARD_F_WAITED_TOO_LONG         As Integer  = &H80100007
    Private Const SCARD_E_INSUFFICIENT_BUFFER     As Integer  = &H80100008
    Private Const SCARD_E_UNKNOWN_READER          As Integer  = &H80100009
    Private Const SCARD_E_TIMEOUT                 As Integer  = &H8010000A
    Private Const SCARD_E_SHARING_VIOLATION       As Integer  = &H8010000B
    Private Const SCARD_E_NO_SMARTCARD            As Integer  = &H8010000C
    Private Const SCARD_E_UNKNOWN_CARD            As Integer  = &H8010000D
    Private Const SCARD_E_CANT_DISPOSE            As Integer  = &H8010000E
    Private Const SCARD_E_PROTO_MISMATCH          As Integer  = &H8010000F
    Private Const SCARD_E_NOT_READY               As Integer  = &H80100010
    Private Const SCARD_E_INVALID_VALUE           As Integer  = &H80100011
    Private Const SCARD_E_SYSTEM_CANCELLED        As Integer  = &H80100012
    Private Const SCARD_E_COMM_ERROR              As Integer  = &H80100013
    Private Const SCARD_F_UNKNOWN_ERROR           As Integer  = &H80100014
    Private Const SCARD_E_INVALID_ATR             As Integer  = &H80100015
    Private Const SCARD_E_NOT_TRANSACTED          As Integer  = &H80100016
    Private Const SCARD_E_READER_UNAVAILABLE      As Integer  = &H80100017
    Private Const SCARD_P_SHUTDOWN                As Integer  = &H80100018
    Private Const SCARD_E_PCI_TOO_SMALL           As Integer  = &H80100019
    Private Const SCARD_E_READER_UNSUPPORTED      As Integer  = &H8010001A
    Private Const SCARD_E_DUPLICATE_READER        As Integer  = &H8010001B
    Private Const SCARD_E_CARD_UNSUPPORTED        As Integer  = &H8010001C
    Private Const SCARD_E_NO_SERVICE              As Integer  = &H8010001D
    Private Const SCARD_E_SERVICE_STOPPED         As Integer  = &H8010001E
    Private Const SCARD_E_UNEXPECTED              As Integer  = &H8010001F
    Private Const SCARD_E_ICC_INSTALLATION        As Integer  = &H80100020
    Private Const SCARD_E_ICC_CREATEORDER         As Integer  = &H80100021
    Private Const SCARD_E_UNSUPPORTED_FEATURE     As Integer  = &H80100022
    Private Const SCARD_E_DIR_NOT_FOUND           As Integer  = &H80100023
    Private Const SCARD_E_FILE_NOT_FOUND          As Integer  = &H80100024
    Private Const SCARD_E_NO_DIR                  As Integer  = &H80100025
    Private Const SCARD_E_NO_FILE                 As Integer  = &H80100026
    Private Const SCARD_E_NO_ACCESS               As Integer  = &H80100027
    Private Const SCARD_E_WRITE_TOO_MANY          As Integer  = &H80100028
    Private Const SCARD_E_BAD_SEEK                As Integer  = &H80100029
    Private Const SCARD_E_INVALID_CHV             As Integer  = &H8010002A
    Private Const SCARD_E_UNKNOWN_RES_MNG         As Integer  = &H8010002B
    Private Const SCARD_E_NO_SUCH_CERTIFICATE     As Integer  = &H8010002C
    Private Const SCARD_E_CERTIFICATE_UNAVAILABLE As Integer  = &H8010002D
    Private Const SCARD_E_NO_READERS_AVAILABLE    As Integer  = &H8010002E
    Private Const SCARD_E_COMM_DATA_LOST          As Integer  = &H8010002F
    Private Const SCARD_E_NO_KEY_CONTAINER        As Integer  = &H80100030
    Private Const SCARD_E_SERVER_TOO_BUSY         As Integer  = &H80100031
    Private Const SCARD_E_PIN_CACHE_EXPIRED       As Integer  = &H80100032
    Private Const SCARD_E_NO_PIN_CACHE            As Integer  = &H80100033
    Private Const SCARD_E_READ_ONLY_CARD          As Integer  = &H80100034
    Private Const SCARD_W_UNSUPPORTED_CARD        As Integer  = &H80100065
    Private Const SCARD_W_UNRESPONSIVE_CARD       As Integer  = &H80100066
    Private Const SCARD_W_UNPOWERED_CARD          As Integer  = &H80100067
    Private Const SCARD_W_RESET_CARD              As Integer  = &H80100068
    Private Const SCARD_W_REMOVED_CARD            As Integer  = &H80100069
    Private Const SCARD_W_SECURITY_VIOLATION      As Integer  = &H8010006A
    Private Const SCARD_W_WRONG_CHV               As Integer  = &H8010006B
    Private Const SCARD_W_CHV_BLOCKED             As Integer  = &H8010006C
    Private Const SCARD_W_EOF                     As Integer  = &H8010006D
    Private Const SCARD_W_CANCELLED_BY_USER       As Integer  = &H8010006E
    Private Const SCARD_W_CARD_NOT_AUTHENTICATED  As Integer  = &H8010006F
    Private Const SCARD_W_CACHE_ITEM_NOT_FOUND    As Integer  = &H80100070
    Private Const SCARD_W_CACHE_ITEM_STALE        As Integer  = &H80100071
    Private Const SCARD_W_CACHE_ITEM_TOO_BIG      As Integer  = &H80100072
    Private Const SCARD_PROTOCOL_T0               As Integer  = 1
    Private Const SCARD_PROTOCOL_T1               As Integer  = 2
    Private Const SCARD_PROTOCOL_RAW              As Integer  = 4
    Private Const SCARD_SCOPE_USER                As UInteger = 0
    Private Const SCARD_SCOPE_TERMINAL            As UInteger = 1
    Private Const SCARD_SCOPE_SYSTEM              As UInteger = 2
    Private Const SCARD_STATE_UNAWARE             As Integer  = &H0
    Private Const SCARD_STATE_IGNORE              As Integer  = &H1
    Private Const SCARD_STATE_CHANGED             As Integer  = &H2
    Private Const SCARD_STATE_UNKNOWN             As Integer  = &H4
    Private Const SCARD_STATE_UNAVAILABLE         As Integer  = &H8
    Private Const SCARD_STATE_EMPTY               As Integer  = &H10
    Private Const SCARD_STATE_PRESENT             As Integer  = &H20
    Private Const SCARD_STATE_AIRMATCH            As Integer  = &H40
    Private Const SCARD_STATE_EXCLUSIVE           As Integer  = &H80
    Private Const SCARD_STATE_INUSE               As Integer  = &H100
    Private Const SCARD_STATE_MUTE                As Integer  = &H200
    Private Const SCARD_STATE_UNPOWERED           As Integer  = &H400
    Private Const SCARD_SHARE_EXCLUSIVE           As Integer  = &H1
    Private Const SCARD_SHARE_SHARED              As Integer  = &H2
    Private Const SCARD_SHARE_DIRECT              As Integer  = &H3
    Private Const SCARD_LEAVE_CARD                As Integer  = 0
    Private Const SCARD_RESET_CARD                As Integer  = 1
    Private Const SCARD_UNPOWER_CARD              As Integer  = 2
    Private Const SCARD_EJECT_CARD                As Integer  = 3

    Private Const SCARD_UNKNOWN                   As Integer  = 0
    Private Const SCARD_ABSENT                    As Integer  = 1
    Private Const SCARD_PRESENT                   As Integer  = 2
    Private Const SCARD_SWALLOWED                 As Integer  = 3
    Private Const SCARD_POWERED                   As Integer  = 4
    Private Const SCARD_NEGOTIABLE                As Integer  = 5
    Private Const SCARD_SPECIFIC                  As Integer  = 6

    '========================================
    ' SCardGetStatusChange()で使用する構造体
    '========================================
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
    Private Structure SCARD_READERSTATE
        <MarshalAs(UnmanagedType.LPTStr)> _
        Public szReader       As String
        Public pvUserData     As IntPtr
        Public dwCurrentState As UInteger
        Public dwEventState   As UInteger
        Public cbAtr          As UInteger
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=36)> _
        Public rgbAtr()       As Byte

        Sub Initialize()
            szReader       = ""
            pvUserData     = 0
            dwCurrentState = 0
            dwEventState   = 0
            cbAtr          = 0
            ReDim rgbAtr(35)
        End Sub
    End Structure

    '=================================
    ' SCardTransmit()で使用する構造体
    '=================================
    <StructLayout(LayoutKind.Sequential)> _
    Private Structure SCARD_IO_REQUEST
        Public dwProtocol  As UInteger
        Public cbPciLength As UInteger
    End Structure

    '==============
    ' WinSCard API
    '==============
    <DllImport("winscard.dll", EntryPoint:="SCardEstablishContext", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function SCardEstablishContext( _
        ByVal dwScope     As UInteger, _
        ByVal pvReserved1 As IntPtr, _
        ByVal pvReserved2 As IntPtr, _
        ByRef phContext   As IntPtr _
    ) As UInteger
    End Function

    <DllImport("winscard.dll", EntryPoint:="SCardListReaders", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function SCardListReaders( _
        ByVal hContext    As IntPtr, _
        ByVal mszGroups   As Byte(), _
        ByVal mszReaders  As Byte(), _
        ByRef pcchReaders As UInteger _
    ) As UInteger
    End Function

    <DllImport("winscard.dll", EntryPoint:="SCardGetStatusChange", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function SCardGetStatusChange( _
        ByVal hContext       As IntPtr, _
        ByVal dwTimeout      As Integer, _
        ByRef rgReaderStates As SCARD_READERSTATE, _
        ByVal cReaders       As Integer _
    ) As UInteger
    End Function

    <DllImport("winscard.dll", EntryPoint:="SCardConnect", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function SCardConnect( _
        ByVal hContext             As IntPtr, _
        ByVal szReader             As String, _
        ByVal dwShareMode          As UInteger, _
        ByVal dwPreferredProtocols As UInteger, _
        ByRef phCard               As IntPtr, _
        ByRef pdwActiveProtocol    As IntPtr _
    ) As UInteger
    End Function

    <DllImport("winscard.dll", EntryPoint:="SCardStatus", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function SCardStatus( _
        ByVal hCard         As IntPtr, _
        ByVal szReaderName  As StringBuilder, _
        ByRef pcchReaderLen As UInteger, _
        ByRef pdwState      As UInteger, _
        ByRef pdwProtocol   As UInteger, _
        ByVal pbAtr         As Byte(), _
        ByRef pcbAtrLen     As Integer _
    ) As UInteger
    End Function

    <DllImport("winscard.dll", EntryPoint:="SCardTransmit", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function SCardTransmit( _
        ByVal hCard          As IntPtr, _
        ByVal pioSendRequest As IntPtr, _
        ByVal SendBuff       As Byte(), _
        ByVal SendBuffLen    As Integer, _
        ByRef pioRecvRequest As SCARD_IO_REQUEST, _
        ByVal RecvBuff       As Byte(), _
        ByRef RecvBuffLen    As Integer _
    ) As UInteger
    End Function

    <DllImport("winscard.dll", EntryPoint:="SCardDisconnect", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function SCardDisconnect( _
        ByVal hCard       As IntPtr, _
        ByVal Disposition As Integer _
    ) As UInteger
    End Function

    '<DllImport("winscard.dll", EntryPoint:="SCardFreeMemory", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    'Private Shared Function SCardFreeMemory( _
    '    ByVal hContext As IntPtr, _
    '    ByVal pvMem    As IntPtr _
    ') As UInteger
    'End Function

    <DllImport("winscard.dll", EntryPoint:="SCardReleaseContext", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function SCardReleaseContext(ByVal phContext As IntPtr) As UInteger
    End Function

    '===========
    ' Win32 API
    '===========
    <DllImport("kernel32.dll", EntryPoint:="LoadLibrary", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function LoadLibrary(ByVal lpFileName As String) As IntPtr
    End Function

    <DllImport("kernel32.dll", EntryPoint:="FreeLibrary", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Sub FreeLibrary(ByVal handle As IntPtr)
    End Sub

    <DllImport("kernel32.dll", EntryPoint:="GetProcAddress", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function GetProcAddress(ByVal handle As IntPtr, ByVal procName As String) As IntPtr
    End Function

    '=========================
    ' エラーメッセージ取得(1)
    '=========================
    Private Function GetErrorMessage(ByVal errNo As UInteger) As String
        Dim strMessage As String = vbNullString

        Select Case errNo
            Case GetUInteger(SCARD_F_INTERNAL_ERROR)
                strMessage = "[Error] " + errNo.ToString + " INTERNAL ERROR"
            Case GetUInteger(SCARD_E_CANCELLED)
                strMessage = "[Error] " + errNo.ToString + " CANCELLED"
            Case GetUInteger(SCARD_E_INVALID_HANDLE)
                strMessage = "[Error] " + errNo.ToString + " INVALID HANDLE"
            Case GetUInteger(SCARD_E_INVALID_PARAMETER)
                strMessage = "[Error] " + errNo.ToString + " INVALID PARAMETER"
            Case GetUInteger(SCARD_E_INVALID_TARGET)
                strMessage = "[Error] " + errNo.ToString + " INVALID TARGET"
            Case GetUInteger(SCARD_E_NO_MEMORY)
                strMessage = "[Error] " + errNo.ToString + " NO MEMORY"
            Case GetUInteger(SCARD_F_WAITED_TOO_LONG)
                strMessage = "[Error] " + errNo.ToString + " WAITED TOO LONG"
            Case GetUInteger(SCARD_E_INSUFFICIENT_BUFFER)
                strMessage = "[Error] " + errNo.ToString + " INSUFFICIENT BUFFER"
            Case GetUInteger(SCARD_E_UNKNOWN_READER)
                strMessage = "[Error] " + errNo.ToString + " UNKNOWN READER"
            Case GetUInteger(SCARD_E_TIMEOUT)
                strMessage = "[Error] " + errNo.ToString + " TIMEOUT"
            Case GetUInteger(SCARD_E_SHARING_VIOLATION)
                strMessage = "[Error] " + errNo.ToString + " SHARING VIOLATION"
            Case GetUInteger(SCARD_E_NO_SMARTCARD)
                strMessage = "[Error] " + errNo.ToString + " NO SMARTCARD"
            Case GetUInteger(SCARD_E_UNKNOWN_CARD)
                strMessage = "[Error] " + errNo.ToString + " UNKNOWN CARD"
            Case GetUInteger(SCARD_E_CANT_DISPOSE)
                strMessage = "[Error] " + errNo.ToString + " CANT DISPOSE"
            Case GetUInteger(SCARD_E_PROTO_MISMATCH)
                strMessage = "[Error] " + errNo.ToString + " PROTO MISMATCH"
            Case GetUInteger(SCARD_E_NOT_READY)
                strMessage = "[Error] " + errNo.ToString + " NOT READY"
            Case GetUInteger(SCARD_E_INVALID_VALUE)
                strMessage = "[Error] " + errNo.ToString + " INVALID VALUE"
            Case GetUInteger(SCARD_E_SYSTEM_CANCELLED)
                strMessage = "[Error] " + errNo.ToString + " SYSTEM CANCELLED"
            Case GetUInteger(SCARD_E_COMM_ERROR)
                strMessage = "[Error] " + errNo.ToString + " COMM ERROR"
            Case GetUInteger(SCARD_F_UNKNOWN_ERROR)
                strMessage = "[Error] " + errNo.ToString + " UNKNOWN ERROR"
            Case GetUInteger(SCARD_E_INVALID_ATR)
                strMessage = "[Error] " + errNo.ToString + " INVALID ATR"
            Case GetUInteger(SCARD_E_NOT_TRANSACTED)
                strMessage = "[Error] " + errNo.ToString + " NOT TRANSACTED"
            Case GetUInteger(SCARD_E_READER_UNAVAILABLE)
                strMessage = "[Error] " + errNo.ToString + " READER UNAVAILABLE"
            Case GetUInteger(SCARD_P_SHUTDOWN)
                strMessage = "[Error] " + errNo.ToString + " SHUTDOWN"
            Case GetUInteger(SCARD_E_PCI_TOO_SMALL)
                strMessage = "[Error] " + errNo.ToString + " PCI TOO SMALL"
            Case GetUInteger(SCARD_E_READER_UNSUPPORTED)
                strMessage = "[Error] " + errNo.ToString + " READER UNSUPPORTED"
            Case GetUInteger(SCARD_E_DUPLICATE_READER)
                strMessage = "[Error] " + errNo.ToString + " DUPLICATE READER"
            Case GetUInteger(SCARD_E_CARD_UNSUPPORTED)
                strMessage = "[Error] " + errNo.ToString + " CARD UNSUPPORTED"
            Case GetUInteger(SCARD_E_NO_SERVICE)
                strMessage = "[Error] " + errNo.ToString + " NO SERVICE"
            Case GetUInteger(SCARD_E_SERVICE_STOPPED)
                strMessage = "[Error] " + errNo.ToString + " SERVICE STOPPED"
            Case GetUInteger(SCARD_E_UNEXPECTED)
                strMessage = "[Error] " + errNo.ToString + " UNEXPECTED"
            Case GetUInteger(SCARD_E_ICC_INSTALLATION)
                strMessage = "[Error] " + errNo.ToString + " ICC INSTALLATION"
            Case GetUInteger(SCARD_E_ICC_CREATEORDER)
                strMessage = "[Error] " + errNo.ToString + " ICC CREATEORDER"
            Case GetUInteger(SCARD_E_UNSUPPORTED_FEATURE)
                strMessage = "[Error] " + errNo.ToString + " UNSUPPORTED FEATURE"
            Case GetUInteger(SCARD_E_DIR_NOT_FOUND)
                strMessage = "[Error] " + errNo.ToString + " DIR NOT FOUND"
            Case GetUInteger(SCARD_E_FILE_NOT_FOUND)
                strMessage = "[Error] " + errNo.ToString + " FILE NOT FOUND"
            Case GetUInteger(SCARD_E_NO_DIR)
                strMessage = "[Error] " + errNo.ToString + " NO DIR"
            Case GetUInteger(SCARD_E_NO_FILE)
                strMessage = "[Error] " + errNo.ToString + " NO FILE"
            Case GetUInteger(SCARD_E_NO_ACCESS)
                strMessage = "[Error] " + errNo.ToString + " NO ACCESS"
            Case GetUInteger(SCARD_E_WRITE_TOO_MANY)
                strMessage = "[Error] " + errNo.ToString + " WRITE TOO MANY"
            Case GetUInteger(SCARD_E_BAD_SEEK)
                strMessage = "[Error] " + errNo.ToString + " BAD SEEK"
            Case GetUInteger(SCARD_E_INVALID_CHV)
                strMessage = "[Error] " + errNo.ToString + " INVALID CHV"
            Case GetUInteger(SCARD_E_UNKNOWN_RES_MNG)
                strMessage = "[Error] " + errNo.ToString + " UNKNOWN RES MNG"
            Case GetUInteger(SCARD_E_NO_SUCH_CERTIFICATE)
                strMessage = "[Error] " + errNo.ToString + " NO SUCH CERTIFICATE"
            Case GetUInteger(SCARD_E_CERTIFICATE_UNAVAILABLE)
                strMessage = "[Error] " + errNo.ToString + " CERTIFICATE UNAVAILABLE"
            Case GetUInteger(SCARD_E_NO_READERS_AVAILABLE)
                strMessage = "[Error] " + errNo.ToString + " NO READERS AVAILABLE"
            Case GetUInteger(SCARD_E_COMM_DATA_LOST)
                strMessage = "[Error] " + errNo.ToString + " COMM DATA LOST"
            Case GetUInteger(SCARD_E_NO_KEY_CONTAINER)
                strMessage = "[Error] " + errNo.ToString + " NO KEY CONTAINER"
            Case GetUInteger(SCARD_E_SERVER_TOO_BUSY)
                strMessage = "[Error] " + errNo.ToString + " SERVER TOO BUSY"
            Case GetUInteger(SCARD_E_PIN_CACHE_EXPIRED)
                strMessage = "[Error] " + errNo.ToString + " PIN CACHE EXPIRED"
            Case GetUInteger(SCARD_E_NO_PIN_CACHE)
                strMessage = "[Error] " + errNo.ToString + " NO PIN CACHE"
            Case GetUInteger(SCARD_E_READ_ONLY_CARD)
                strMessage = "[Error] " + errNo.ToString + " READ ONLY CARD"
            Case GetUInteger(SCARD_W_UNSUPPORTED_CARD)
                strMessage = "[Error] " + errNo.ToString + " UNSUPPORTED CARD"
            Case GetUInteger(SCARD_W_UNRESPONSIVE_CARD)
                strMessage = "[Error] " + errNo.ToString + " UNRESPONSIVE CARD"
            Case GetUInteger(SCARD_W_UNPOWERED_CARD)
                strMessage = "[Error] " + errNo.ToString + " UNPOWERED CARD"
            Case GetUInteger(SCARD_W_RESET_CARD)
                strMessage = "[Error] " + errNo.ToString + " RESET CARD"
            Case GetUInteger(SCARD_W_REMOVED_CARD)
                strMessage = "[Error] " + errNo.ToString + " REMOVED CARD"
            Case GetUInteger(SCARD_W_SECURITY_VIOLATION)
                strMessage = "[Error] " + errNo.ToString + " SECURITY VIOLATION"
            Case GetUInteger(SCARD_W_WRONG_CHV)
                strMessage = "[Error] " + errNo.ToString + " WRONG CHV"
            Case GetUInteger(SCARD_W_CHV_BLOCKED)
                strMessage = "[Error] " + errNo.ToString + " CHV BLOCKED"
            Case GetUInteger(SCARD_W_EOF)
                strMessage = "[Error] " + errNo.ToString + " EOF"
            Case GetUInteger(SCARD_W_CANCELLED_BY_USER)
                strMessage = "[Error] " + errNo.ToString + " CANCELLED BY USER"
            Case GetUInteger(SCARD_W_CARD_NOT_AUTHENTICATED)
                strMessage = "[Error] " + errNo.ToString + " CARD NOT AUTHENTICATED"
            Case GetUInteger(SCARD_W_CACHE_ITEM_NOT_FOUND)
                strMessage = "[Error] " + errNo.ToString + " CACHE ITEM NOT FOUND"
            Case GetUInteger(SCARD_W_CACHE_ITEM_STALE)
                strMessage = "[Error] " + errNo.ToString + " CACHE ITEM STALE"
            Case GetUInteger(SCARD_W_CACHE_ITEM_TOO_BIG)
                strMessage = "[Error] " + errNo.ToString + " CACHE ITEM TOO BIG"
            Case Else
                strMessage = "[Error] " + errNo.ToString + " OTHER ERROR"
        End Select

        Return strMessage
    End Function

    '=========================
    ' エラーメッセージ取得(2)
    '=========================
    Private Function GetErrorMessage_SCardStatus(ByVal errNo As UInteger) As String
        Dim strMessage As String = vbNullString

        Select Case errNo
            Case GetUInteger(SCARD_UNKNOWN)
                strMessage = "[Error] " + errNo.ToString + " The card state is unknown or unexpected."
            Case GetUInteger(SCARD_ABSENT)
                strMessage = "[Error] " + errNo.ToString + " There is no card in the reader."
            Case GetUInteger(SCARD_PRESENT)
                strMessage = "[Error] " + errNo.ToString + " There is a card in the reader, but it has not been moved into position for use."
            Case GetUInteger(SCARD_SWALLOWED)
                strMessage = "[Error] " + errNo.ToString + " There is a card in the reader in position for use. The card is not powered."
            Case GetUInteger(SCARD_POWERED)
                strMessage = "[Error] " + errNo.ToString + " Power is being provided to the card, but the reader driver is unaware of the mode of the card."
            Case GetUInteger(SCARD_NEGOTIABLE)
                strMessage = "[Error] " + errNo.ToString + " The card has been reset and is awaiting PTS negotiation."
            Case Else
                strMessage = "[Error] " + errNo.ToString + " OTHER ERROR"
        End Select

        Return strMessage
    End Function

    '==========================================
    ' 符号あり整数型から、符号なし整数型に変換
    '==========================================
    Private Function GetUInteger(ByVal p_Value As Integer) As UInteger
        Return p_Value + 2 ^ 32
    End Function

    '================
    ' プロパティ宣言
    '================
    Private _Timeout_MilliSecond As Integer  'タイムアウトする時間(ミリ秒)
    Private _CardType As String   'カードの種類
    Private _IsFelica As Boolean  'Felicaフラグ
    Private _IsMifare As Boolean  'Mifareフラグ
    Private _IDm As String   'FelicaのIDm
    Private _PMm As String   'FelicaのPMm
    Private _UID As String   'MifareのUID
    Private _ErrorMsg As String   'エラーメッセージ

    Public Property Timeout_MilliSecond() As Integer
        Get
            Return _Timeout_MilliSecond
        End Get
        Set(value As Integer)
            _Timeout_MilliSecond = value
        End Set
    End Property

    Public ReadOnly Property CardType() As String
        Get
            Return _CardType
        End Get
    End Property

    Public ReadOnly Property IsFelica() As Boolean
        Get
            Return _IsFelica
        End Get
    End Property

    Public ReadOnly Property IsMifare() As Boolean
        Get
            Return _IsMifare
        End Get
    End Property

    Public ReadOnly Property IDm() As String
        Get
            Return _IDm
        End Get
    End Property

    Public ReadOnly Property PMm() As String
        Get
            Return _PMm
        End Get
    End Property

    Public ReadOnly Property UID() As String
        Get
            Return _UID
        End Get
    End Property

    Public ReadOnly Property ErrorMsg() As String
        Get
            Return _ErrorMsg
        End Get
    End Property

    '============
    ' メンバ変数
    '============
    Private hContext As IntPtr
    Private mReader As String
    Private hCard As IntPtr

    'Private SCARD_PCI_T0  As IntPtr
    Private SCARD_PCI_T1 As IntPtr
    'Private SCARD_PCI_RAW As IntPtr

    Private sendBuffer_IDm As Byte() = New Byte() {&HFF, &HCA, &H0, &H0, &H0}  'Felica IDm取得コマンド
    Private sendBuffer_PMm As Byte() = New Byte() {&HFF, &HCA, &H1, &H0, &H0}  'Felica PMm取得コマンド
    Private sendBuffer_UID As Byte() = New Byte() {&HFF, &HCA, &H0, &H0, &H4}  'Mifare UID取得コマンド

    Private URtn As UInteger

    '================
    ' コンストラクタ
    '================
    Public Sub New()
        '--------
        ' 初期化
        '--------
        Dim hLoader As IntPtr = LoadLibrary("winscard.dll")
        'SCARD_PCI_T0  = GetProcAddress(hLoader, "g_rgSCardT0Pci")
        SCARD_PCI_T1 = GetProcAddress(hLoader, "g_rgSCardT1Pci")
        'SCARD_PCI_RAW = GetProcAddress(hLoader, "g_rgSCardRawPci")
        FreeLibrary(hLoader)

        Me._Timeout_MilliSecond = Timeout.Infinite
        Me._CardType = String.Empty
        Me._IsFelica = False
        Me._IsMifare = False
        Me._IDm = String.Empty
        Me._PMm = String.Empty
        Me._UID = String.Empty
        Me._ErrorMsg = String.Empty
    End Sub

    '======================================
    ' (1)SCardEstablishContext
    ' ⇒リソースマネージャのハンドルを取得
    '======================================
    Private Function EstablishContext() As Boolean
        URtn = SCardEstablishContext(SCARD_SCOPE_USER, Nothing, Nothing, Me.hContext)
        If URtn <> SCARD_S_SUCCESS Then
            Me._ErrorMsg = GetErrorMessage(URtn)
            Return False
        End If

        Return True
    End Function

    '==================================
    ' (2)SCardListReaders
    ' ⇒リーダー／ライターの名称を取得
    '==================================
    Private Function ListReaders() As Boolean
        Dim pcchReaders As UInteger = 0
        Dim mszReaders As Byte()

        URtn = SCardListReaders(Me.hContext, Nothing, Nothing, pcchReaders)
        If URtn <> SCARD_S_SUCCESS Then
            Me._ErrorMsg = GetErrorMessage(URtn)
            Return False
        End If

        mszReaders = New Byte(Convert.ToInt32(pcchReaders) * 2 - 1) {}
        URtn = SCardListReaders(Me.hContext, Nothing, mszReaders, pcchReaders)
        If URtn <> SCARD_S_SUCCESS Then
            Me._ErrorMsg = GetErrorMessage(URtn)
            Return False
        End If

        '取得したカードリーダーの名前をNULLで分割
        Me.mReader = ""
        Dim reader As String() = (New UnicodeEncoding).GetString(mszReaders).Split(vbNullChar)
        For I As Integer = 0 To reader.Length() - 1
            'PaSoRiの文字があるか確認
            If reader(I).IndexOf("pasori", StringComparison.InvariantCultureIgnoreCase) >= 0 Then
                Me.mReader = reader(I)
                Exit For
            End If
        Next

        If Me.mReader = "" Then
            Me._ErrorMsg = "[Error] PaSoRi NOT FOUND."
            Return False
        End If

        Return True
    End Function

    '==================================
    ' (3)SCardGetStatusChange
    ' ⇒リーダー／ライターの状態を取得
    '==================================
    Private Function GetStatusChange() As Boolean
        Dim srReaderState As New SCARD_READERSTATE
        srReaderState.Initialize()
        srReaderState.szReader = Me.mReader
        srReaderState.dwCurrentState = SCARD_STATE_UNAWARE

        URtn = SCardGetStatusChange(Me.hContext, 100, srReaderState, 1)
        If URtn <> SCARD_S_SUCCESS Then
            Me._ErrorMsg = GetErrorMessage(URtn)
            Return False
        End If

        If (srReaderState.dwEventState And SCARD_STATE_EMPTY) <> 0 Then
            srReaderState.dwCurrentState = srReaderState.dwEventState

            'URtn = SCardGetStatusChange(hContext, Timeout.Infinite, srReaderState, 1)    '待ち時間、無限
            URtn = SCardGetStatusChange(hContext, _Timeout_MilliSecond, srReaderState, 1) '待ち時間を指定して実行
            If URtn <> SCARD_S_SUCCESS Then
                Me._ErrorMsg = GetErrorMessage(URtn)
                Return False
            End If

            If (srReaderState.dwEventState And SCARD_STATE_PRESENT) <> 0 Then
                'カードがセットされました
                Return True
            ElseIf (srReaderState.dwEventState And SCARD_STATE_UNAVAILABLE) <> 0 Then
                'カードリーダが外されました
                Me._ErrorMsg = "[Error] Card is Unavailable."
                Return False
            Else
            End If
        ElseIf (srReaderState.dwEventState And SCARD_STATE_PRESENT) <> 0 Then
            'カードは既にセットされています
            Return True
        Else
        End If

        Me._ErrorMsg = "[Error] Unknown error at GetStatusChange()."
        Return False
    End Function

    '=================
    ' (4)SCardConnect
    ' ⇒カードに接続
    '=================
    Private Function Connect() As Boolean
        Dim pdwActiveProtocol As IntPtr = IntPtr.Zero
        Dim time As UInteger = 0

        'カードに接続してみる
        URtn = SCardConnect(Me.hContext, _
                            Me.mReader, _
                            SCARD_SHARE_SHARED, _
                            SCARD_PROTOCOL_T1, _
                            Me.hCard, _
                            pdwActiveProtocol)
        'エラーの場合
        If URtn <> SCARD_S_SUCCESS Then
            Me._ErrorMsg = GetErrorMessage(URtn)
            Return False
        End If

        Return True
    End Function

    '================================================
    ' (5)SCardStatus
    ' ⇒ATR(Answer To Reset)を取得しカード種別を判定
    '================================================
    Private Function Status() As Boolean
        Dim szReaderName  As StringBuilder
        Dim pcchReaderLen As UInteger = 0
        Dim dwState       As UInteger = 0
        Dim pdwProtocol   As IntPtr   = IntPtr.Zero
        Dim pbAtr         As Byte()
        Dim dwAtrLen      As UInteger = 0

        pcchReaderLen = 0
        dwAtrLen = 0
        URtn = SCardStatus(
                   Me.hCard, _
                   Nothing, _
                   pcchReaderLen, _
                   dwState, _
                   pdwProtocol, _
                   Nothing, _
                   dwAtrLen)
        If URtn = SCARD_S_SUCCESS Then
            If dwState <> SCARD_SPECIFIC Then
                Me._ErrorMsg = GetErrorMessage_SCardStatus(dwState)
                Return False
            End If
        Else
            Me._ErrorMsg = GetErrorMessage(URtn)
            Return False
        End If

        szReaderName = New StringBuilder(Convert.ToInt32(pcchReaderLen))
        pbAtr = New Byte(dwAtrLen - 1) {}
        URtn = SCardStatus(
                   Me.hCard, _
                   szReaderName, _
                   pcchReaderLen, _
                   dwState, _
                   pdwProtocol, _
                   pbAtr, _
                   dwAtrLen)
        If URtn = SCARD_S_SUCCESS Then
            If dwState <> SCARD_SPECIFIC Then
                Me._ErrorMsg = GetErrorMessage_SCardStatus(dwState)
                Return False
            End If
        Else
            Me._ErrorMsg = GetErrorMessage(URtn)
            Return False
        End If

        ' ATRのデータ長をチェック
        If pbAtr.Length() < 15 Then
            Me._ErrorMsg = "[Error] ATR data is too short."
            Return False
        End If

        ' カードの種類をチェック
        '--------------------------
        ' 00 01: MIFARE Classic 1K
        ' 00 02: MIFARE Classic 4K
        ' 00 03: MIFARE Ultralight
        ' 00 26: MIFARE Mini
        ' 00 3B: FeliCa
        '--------------------------
        If pbAtr(13) = &H0 AndAlso pbAtr(14) = &H1 Then
            Me._CardType = "Mifare Classic 1K"
            Me._IsMifare = True
        ElseIf pbAtr(13) = &H0 AndAlso pbAtr(14) = &H2 Then
            Me._CardType = "Mifare Classic 4K"
            Me._IsMifare = True
        ElseIf pbAtr(13) = &H0 AndAlso pbAtr(14) = &H3 Then
            Me._CardType = "Mifare Ultralight"
            Me._IsMifare = True
        ElseIf pbAtr(13) = &H0 AndAlso pbAtr(14) = &H26 Then
            Me._CardType = "Mifare Mini"
            Me._IsMifare = True
        ElseIf pbAtr(13) = &H0 AndAlso pbAtr(14) = &H3B Then
            Me._CardType = "Felica"
            Me._IsFelica = True
        Else
            Me._ErrorMsg = "[Error] Card is not Felica or Mifare."
            Return False
        End If

        Return True
    End Function

    '======================================
    ' (6)SCardTransmit
    ' ⇒カードにコマンド送信・データを受信
    '--------------------------------------
    '【第１引数】[in]  送信するコマンド
    '【第２引数】[out] 受信用のバッファ
    '【第３引数】[out] 受信データの長さ
    '======================================
    Private Function Transmit(ByVal sendBuffer As Byte(), ByRef recvBuffer As Byte(), ByRef recvBufferLen As Integer) As Boolean
        ReDim recvBuffer(511)
        recvBufferLen = recvBuffer.Length
        Dim pioRecvRequest As SCARD_IO_REQUEST = New SCARD_IO_REQUEST()
        pioRecvRequest.cbPciLength = 255

        URtn = SCardTransmit(Me.hCard, _
                             Me.SCARD_PCI_T1, _
                             sendBuffer, _
                             sendBuffer.Length, _
                             pioRecvRequest, _
                             recvBuffer, _
                             recvBufferLen)
        If URtn <> SCARD_S_SUCCESS Then
            Me._ErrorMsg = GetErrorMessage(URtn)
            Return False
        End If

        Return True
    End Function

    '========================
    ' (7)SCardDisconnect
    ' ⇒カードとの通信を切断
    '========================
    Private Sub Disconnect()
        If Me.hCard <> IntPtr.Zero Then
            SCardDisconnect(Me.hCard, SCARD_LEAVE_CARD)
        End If
    End Sub

    '======================================
    ' (8)SCardReleaseContext
    ' ⇒リソースマネージャのハンドルを解放
    '======================================
    Private Sub ReleaseContext()
        If Me.hContext <> IntPtr.Zero Then
            SCardReleaseContext(Me.hContext)
        End If
    End Sub

    '======================
    ' カードのIDを取得する
    '======================
    Public Function getCardID() As Boolean
        '------------------
        ' プロパティ初期化
        '------------------
        Me._CardType = String.Empty
        Me._IsFelica = False
        Me._IsMifare = False
        Me._IDm      = String.Empty
        Me._PMm      = String.Empty
        Me._UID      = String.Empty
        Me._ErrorMsg = String.Empty

        '------------------------------------
        ' FelicaのIDm,PMm・MifareのUIDを取得
        '------------------------------------
        Try
            ' (1)SCardEstablishContext
            ' ⇒リソースマネージャのハンドルを取得
            If Not Me.EstablishContext() Then
                Me.Disconnect()
                Me.ReleaseContext()
                Return False
            End If

            ' (2)SCardListReaders
            ' ⇒リーダー／ライターの名称を取得
            If Not Me.ListReaders() Then
                Me.Disconnect()
                Me.ReleaseContext()
                Return False
            End If

            ' (3)SCardGetStatusChange
            ' ⇒リーダー／ライターの状態を取得
            If Not Me.GetStatusChange() Then
                Me.Disconnect()
                Me.ReleaseContext()
                Return False
            End If

            ' (4)SCardConnect
            ' ⇒カードに接続
            If Not Me.Connect() Then
                Me.Disconnect()
                Me.ReleaseContext()
                Return False
            End If

            ' (5)SCardStatus
            ' ⇒ATR(Answer To Reset)を取得しカード種別を判定
            If Not Me.Status() Then
                Me.Disconnect()
                Me.ReleaseContext()
                Return False
            End If

            ' (6)SCardTransmit
            ' ⇒カードにコマンド送信・データを受信
            Dim recvBuffer As Byte() = New Byte(0) {}
            Dim recvBufferLen As Integer
            If Me._IsFelica Then
                'FelicaのIDmを取得
                If Not Me.Transmit(Me.sendBuffer_IDm, recvBuffer, recvBufferLen) Then
                    Me.Disconnect()
                    Me.ReleaseContext()
                    Return False
                End If
                Me._IDm = BitConverter.ToString(recvBuffer, 0, recvBufferLen - 2).Replace("-", String.Empty)

                'FelicaのPMmを取得
                If Not Me.Transmit(Me.sendBuffer_PMm, recvBuffer, recvBufferLen) Then
                    Me.Disconnect()
                    Me.ReleaseContext()
                    Return False
                End If
                Me._PMm = BitConverter.ToString(recvBuffer, 0, recvBufferLen - 2).Replace("-", String.Empty)
            ElseIf Me._IsMifare Then
                'MifareのUIDを取得
                If Not Me.Transmit(Me.sendBuffer_UID, recvBuffer, recvBufferLen) Then
                    Me.Disconnect()
                    Me.ReleaseContext()
                    Return False
                End If
                Me._UID = BitConverter.ToString(recvBuffer, 0, recvBufferLen - 2).Replace("-", String.Empty)
            End If

            ' (7)SCardDisconnect
            ' ⇒カードとの通信を切断
            Me.Disconnect()

            ' (8)SCardReleaseContext
            ' ⇒リソースマネージャのハンドルを解放
            Me.ReleaseContext()

            Return True
        Catch ex As Exception
            Me._ErrorMsg = "[Error] " + ex.Message
            Return False
        End Try
    End Function
End Class
