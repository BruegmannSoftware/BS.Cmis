'***********************************************************************************************************************
'* Project: CmisObjectModelLibrary
'* Copyright (c) 2014, Brügmann Software GmbH, Papenburg, All rights reserved
'* Author: auto-generated code
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
Imports sx = System.Xml
Imports sxs = System.Xml.Serialization
'depends on the chosen interpretation of the xs:integer expression in a xsd-file
#If xs_Integer = "Int32" OrElse xs_integer = "Integer" OrElse xs_integer = "Single" Then
Imports xs_Integer = System.Int32
#Else
Imports xs_Integer = System.Int64
#End If

Namespace CmisObjectModel.Messaging.Requests
   ''' <summary>
   ''' </summary>
   ''' <remarks>
   ''' see getRenditions
   ''' in http://docs.oasis-open.org/cmis/CMIS/v1.1/cs01/schema/CMIS-Messaging.xsd
   ''' </remarks>
   <sxs.XmlRoot("getRenditions", Namespace:=Constants.Namespaces.cmism)>
   Public Class getRenditions
      Inherits Messaging.Requests.RequestBase

      Public Sub New()
      End Sub
      ''' <summary>
      ''' this constructor is only used if derived classes from this class needs an InitClass()-call
      ''' </summary>
      ''' <param name="initClassSupported"></param>
      ''' <remarks></remarks>
      Protected Sub New(initClassSupported As Boolean?)
         MyBase.New(initClassSupported)
      End Sub

#Region "IXmlSerializable"
      Private Shared _setter As New Dictionary(Of String, Action(Of getRenditions, String)) From {
         } '_setter

      ''' <summary>
      ''' Deserialization of all properties stored in attributes
      ''' </summary>
      ''' <param name="reader"></param>
      ''' <remarks></remarks>
      Protected Overrides Sub ReadAttributes(reader As System.Xml.XmlReader)
         'at least one property is serialized in an attribute-value
         If _setter.Count > 0 Then
            For attributeIndex As Integer = 0 To reader.AttributeCount - 1
               reader.MoveToAttribute(attributeIndex)
               'attribute name
               Dim key As String = reader.Name.ToLowerInvariant
               If _setter.ContainsKey(key) Then _setter(key).Invoke(Me, reader.GetAttribute(attributeIndex))
            Next
         End If
      End Sub

      ''' <summary>
      ''' Deserialization of all properties stored in subnodes
      ''' </summary>
      ''' <param name="reader"></param>
      ''' <remarks></remarks>
      Protected Overrides Sub ReadXmlCore(reader As sx.XmlReader, attributeOverrides As Serialization.XmlAttributeOverrides)
         _repositoryId = Read(reader, attributeOverrides, "repositoryId", Constants.Namespaces.cmism, _repositoryId)
         _objectId = Read(reader, attributeOverrides, "objectId", Constants.Namespaces.cmism, _objectId)
         _renditionFilter = Read(reader, attributeOverrides, "renditionFilter", Constants.Namespaces.cmism, _renditionFilter)
         _maxItems = Read(reader, attributeOverrides, "maxItems", Constants.Namespaces.cmism, _maxItems)
         _skipCount = Read(reader, attributeOverrides, "skipCount", Constants.Namespaces.cmism, _skipCount)
         _extension = Read(Of Messaging.cmisExtensionType)(reader, attributeOverrides, "extension", Constants.Namespaces.cmism, AddressOf GenericXmlSerializableFactory(Of Messaging.cmisExtensionType))
      End Sub

      ''' <summary>
      ''' Serialization of properties
      ''' </summary>
      ''' <param name="writer"></param>
      ''' <remarks></remarks>
      Protected Overrides Sub WriteXmlCore(writer As sx.XmlWriter, attributeOverrides As Serialization.XmlAttributeOverrides)
         WriteElement(writer, attributeOverrides, "repositoryId", Constants.Namespaces.cmism, _repositoryId)
         WriteElement(writer, attributeOverrides, "objectId", Constants.Namespaces.cmism, _objectId)
         If Not String.IsNullOrEmpty(_renditionFilter) Then WriteElement(writer, attributeOverrides, "renditionFilter", Constants.Namespaces.cmism, _renditionFilter)
         If _maxItems.HasValue Then WriteElement(writer, attributeOverrides, "maxItems", Constants.Namespaces.cmism, Convert(_maxItems))
         If _skipCount.HasValue Then WriteElement(writer, attributeOverrides, "skipCount", Constants.Namespaces.cmism, Convert(_skipCount))
         WriteElement(writer, attributeOverrides, "extension", Constants.Namespaces.cmism, _extension)
      End Sub
#End Region

      Protected _extension As Messaging.cmisExtensionType
      Public Overridable Property Extension As Messaging.cmisExtensionType
         Get
            Return _extension
         End Get
         Set(value As Messaging.cmisExtensionType)
            If value IsNot _extension Then
               Dim oldValue As Messaging.cmisExtensionType = _extension
               _extension = value
               OnPropertyChanged("Extension", value, oldValue)
            End If
         End Set
      End Property 'Extension

      Protected _maxItems As xs_Integer?
      Public Overridable Property MaxItems As xs_Integer?
         Get
            Return _maxItems
         End Get
         Set(value As xs_Integer?)
            If Not _maxItems.Equals(value) Then
               Dim oldValue As xs_Integer? = _maxItems
               _maxItems = value
               OnPropertyChanged("MaxItems", value, oldValue)
            End If
         End Set
      End Property 'MaxItems

      Protected _objectId As String
      Public Overridable Property ObjectId As String
         Get
            Return _objectId
         End Get
         Set(value As String)
            If _objectId <> value Then
               Dim oldValue As String = _objectId
               _objectId = value
               OnPropertyChanged("ObjectId", value, oldValue)
            End If
         End Set
      End Property 'ObjectId

      Protected _renditionFilter As String
      Public Overridable Property RenditionFilter As String
         Get
            Return _renditionFilter
         End Get
         Set(value As String)
            If _renditionFilter <> value Then
               Dim oldValue As String = _renditionFilter
               _renditionFilter = value
               OnPropertyChanged("RenditionFilter", value, oldValue)
            End If
         End Set
      End Property 'RenditionFilter

      Protected _repositoryId As String
      Public Overridable Property RepositoryId As String
         Get
            Return _repositoryId
         End Get
         Set(value As String)
            If _repositoryId <> value Then
               Dim oldValue As String = _repositoryId
               _repositoryId = value
               OnPropertyChanged("RepositoryId", value, oldValue)
            End If
         End Set
      End Property 'RepositoryId

      Protected _skipCount As xs_Integer?
      Public Overridable Property SkipCount As xs_Integer?
         Get
            Return _skipCount
         End Get
         Set(value As xs_Integer?)
            If Not _skipCount.Equals(value) Then
               Dim oldValue As xs_Integer? = _skipCount
               _skipCount = value
               OnPropertyChanged("SkipCount", value, oldValue)
            End If
         End Set
      End Property 'SkipCount

   End Class
End Namespace