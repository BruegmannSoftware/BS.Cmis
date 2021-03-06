﻿'***********************************************************************************************************************
'* Project: CmisObjectModelLibrary
'* Copyright (c) 2014, Brügmann Software GmbH, Papenburg, All rights reserved
'* Author: BSW_BER
'* Contact: opensource<at>patorg.de
'* 
'* CmisObjectModelLibrary is a VB.NET implementation of the Content Management Interoperability Services (CMIS) standard
'*
'* This file is part of CmisObjectModelLibrary.
'* 
'* This library is free software; you can redistribute it and/or
'* modify it under the terms of the GNU Lesser General Public
'* License as published by the Free Software Foundation; either
'* version 3.0 of the License, or (at your option) any later version.
'*
'* This library is distributed in the hope that it will be useful,
'* but WITHOUT ANY WARRANTY; without even the implied warranty of
'* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
'* Lesser General Public License for more details.
'*
'* You should have received a copy of the GNU Lesser General Public
'* License along with this library (lgpl.txt).
'* If not, see <http://www.gnu.org/licenses/lgpl.txt>.
'***********************************************************************************************************************
Imports CmisObjectModel.Common
'depends on the chosen interpretation of the xs:integer expression in a xsd-file
#If xs_Integer = "Int32" OrElse xs_integer = "Integer" OrElse xs_integer = "Single" Then
Imports xs_Integer = System.Int32
#Else
Imports xs_Integer = System.Int64
#End If

Namespace CmisObjectModel.Core
   <Attributes.JavaScriptConverter(GetType(JSON.Core.cmisRenditionTypeConverter))>
   Partial Class cmisRenditionType
   End Class
End Namespace

Namespace CmisObjectModel.JSON.Core
   <Attributes.AutoGenerated()>
   Partial Public Class cmisRenditionTypeConverter
      Inherits JSON.Serialization.Generic.JavaScriptConverter(Of CmisObjectModel.Core.cmisRenditionType)

#Region "Constructors"
      Public Sub New()
         MyBase.New(New JSON.Serialization.Generic.DefaultObjectResolver(Of CmisObjectModel.Core.cmisRenditionType))
      End Sub
      Public Sub New(objectResolver As Serialization.Generic.ObjectResolver(Of CmisObjectModel.Core.cmisRenditionType))
         MyBase.New(objectResolver)
      End Sub
#End Region

      Protected Overloads Overrides Sub Deserialize(context As SerializationContext)
         With context
            .Object.StreamId = Read(.Dictionary, "streamId", .Object.StreamId)
            .Object.MimeType = Read(.Dictionary, "mimeType", .Object.MimeType)
            .Object.Length = Read(.Dictionary, "length", .Object.Length)
            .Object.Kind = Read(.Dictionary, "kind", .Object.Kind)
            .Object.Title = Read(.Dictionary, "title", .Object.Title)
            .Object.Height = ReadNullable(.Dictionary, "height", .Object.Height)
            .Object.Width = ReadNullable(.Dictionary, "width", .Object.Width)
            .Object.RenditionDocumentId = Read(.Dictionary, "renditionDocumentId", .Object.RenditionDocumentId)
         End With
      End Sub

      Protected Overloads Overrides Sub Serialize(context As SerializationContext)
         With context
            .Add("streamId", .Object.StreamId)
            .Add("mimeType", .Object.MimeType)
            .Add("length", .Object.Length)
            .Add("kind", .Object.Kind)
            If Not String.IsNullOrEmpty(.Object.Title) Then .Add("title", .Object.Title)
            If .Object.Height.HasValue Then .Add("height", .Object.Height.Value)
            If .Object.Width.HasValue Then .Add("width", .Object.Width.Value)
            If Not String.IsNullOrEmpty(.Object.RenditionDocumentId) Then .Add("renditionDocumentId", .Object.RenditionDocumentId)
         End With
      End Sub
   End Class
End Namespace