﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Namespace Emme_Subic_Transport_Corporation_Payroll

    Partial Public Class EmmeSubicEntities
        Inherits DbContext
    
        Public Sub New()
            MyBase.New("name=EmmeSubicEntities")
        End Sub
    
        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub
    
        Public Overridable Property UserDetails() As DbSet(Of UserDetail)
    
    End Class

End Namespace
