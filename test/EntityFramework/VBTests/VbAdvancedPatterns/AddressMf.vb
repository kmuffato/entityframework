'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace AdvancedPatternsVB

    Partial Public Class AddressMf
        Public Property Street As String
    
        Private _City As String
        Public Property City As String
            Private Get
                Return _City
            End Get
            Set(ByVal value As String)
                _City = value
            End Set
        End Property
        Friend Property State As String
    
        Private _ZipCode As String
        Friend Property ZipCode As String
            Get
                Return _ZipCode
            End Get
            Private Set(ByVal value As String)
                _ZipCode = value
            End Set
        End Property
    
    
        Private _SiteInfo As SiteInfoMf = New SiteInfoMf
        Friend Property SiteInfo As SiteInfoMf
            Get
                Return _SiteInfo
            End Get
            Private Set(ByVal value As SiteInfoMf)
                _SiteInfo = value
            End Set
        End Property
    
    End Class

End Namespace
