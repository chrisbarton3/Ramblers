﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=MAIN-I7\SQLEXPRESS;Initial Catalog=chrisbarton_grg10;Integrated Secur"& _ 
            "ity=True")>  _
        Public ReadOnly Property chrisbarton_grg10ConnectionString_Local() As String
            Get
                Return CType(Me("chrisbarton_grg10ConnectionString_Local"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=5.153.14.228,779;Initial Catalog=chrisbarton_grg10;Persist Security I"& _ 
            "nfo=True;User ID=chrisbarton_chris;Password=G@rf0rt#")>  _
        Public ReadOnly Property chrisbarton_grg10ConnectionString_remote() As String
            Get
                Return CType(Me("chrisbarton_grg10ConnectionString_remote"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang2057{\fonttbl{\f0\fswiss\fprq2\fc"& _ 
            "harset0 Calibri;}{\f1\fnil\fcharset0 Calibri;}}"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"{\*\generator Riched20 10.0.171"& _ 
            "34}\viewkind4\uc1 "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\pard\widctlpar\ul\f0\fs24 Ramblers Walk Finder spreadsheet "& _ 
            "fields\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\ulnone Italic fields (*) - not in our database, bold - calculated f"& _ 
            "rom database\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Date\tab\tab\tab\tab\tab as dd/mm/yyy\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Title\tab\tab"& _ 
            "\tab\tab\tab walk name\tab\tab\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Description\tab\tab\tab\tab description\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\i Linear or Circular*\tab\tab\tab\b circular or linear\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\b0\i0 Starting gr"& _ 
            "idref\tab\tab\tab as NN123456\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Starting location details\tab\tab Start Place"& _ 
            "\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\i Show exact starting point?*\tab\tab yes\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\i0 Start time\tab\tab\tab"& _ 
            "\tab as hh:mm\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\i Meeting gridref*\tab\tab\tab\b NO286008(LCCP) or NO269009("& _ 
            "StC)\b0\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Meeting location details*\tab\tab\b Lomond Centre CP or St Columbas"& _ 
            " Church CP\b0\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Show exact meeting point?*\tab\tab yes\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\i0 Meeting time\"& _ 
            "tab\tab\tab\tab as hh:mm\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\i Restriction*\tab\tab\tab\tab Public\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Diffic"& _ 
            "ulty*\tab\tab\tab\tab\b Easy Leisurely Moderate Strenuous\b0\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\i0 Local walk"& _ 
            " grade\tab\tab\tab A - D\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Distance miles\tab\tab\tab distance\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Contact d"& _ 
            "isplay name\tab\tab\tab leader name\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Contact email\tab\tab\tab\tab email\par"& _ 
            ""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Contact telephone 1\tab\tab\tab phone\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\i Is walk leader?*\tab\tab\tab yes"& _ 
            "\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\i0 Ascent feet\tab\tab\tab\tab ascent\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Child friendly?\tab\tab\tab\ta"& _ 
            "b\b Yes or leave blank\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\pard\widctlpar\sa200\sl276\slmult1\b0 Dog friendl"& _ 
            "y?\tab\tab\tab\tab\b Yes or leave blank\b0\fs22\tab\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"\i Linear or circular i"& _ 
            "s derived from walk names.\line Meeting point according to whether Strollers or "& _ 
            "W/e walks.\line Difficulty is calculated from A - D values.\tab\i0\f1\lang9\par"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"}")>  _
        Public Property wfrtf() As String
            Get
                Return CType(Me("wfrtf"),String)
            End Get
            Set
                Me("wfrtf") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2019-02-12")>  _
        Public Property lastajp() As Date
            Get
                Return CType(Me("lastajp"),Date)
            End Get
            Set
                Me("lastajp") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2019-02-12")>  _
        Public Property lastaw() As Date
            Get
                Return CType(Me("lastaw"),Date)
            End Get
            Set
                Me("lastaw") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2019-02-12")>  _
        Public Property lastallw() As Date
            Get
                Return CType(Me("lastallw"),Date)
            End Get
            Set
                Me("lastallw") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2019-02-12")>  _
        Public Property lastlead() As Date
            Get
                Return CType(Me("lastlead"),Date)
            End Get
            Set
                Me("lastlead") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2019-02-12")>  _
        Public Property lastgc() As Date
            Get
                Return CType(Me("lastgc"),Date)
            End Get
            Set
                Me("lastgc") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2019-02-12")>  _
        Public Property lastfp() As Date
            Get
                Return CType(Me("lastfp"),Date)
            End Get
            Set
                Me("lastfp") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2019-02-12")>  _
        Public Property lastprog() As Date
            Get
                Return CType(Me("lastprog"),Date)
            End Get
            Set
                Me("lastprog") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2019-02-12")>  _
        Public Property lastpha() As Date
            Get
                Return CType(Me("lastpha"),Date)
            End Get
            Set
                Me("lastpha") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.LocalGRGmanager.My.MySettings
            Get
                Return Global.LocalGRGmanager.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace