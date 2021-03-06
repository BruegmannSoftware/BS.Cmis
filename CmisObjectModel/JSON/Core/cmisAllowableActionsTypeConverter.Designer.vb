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
   <Attributes.JavaScriptConverter(GetType(JSON.Core.cmisAllowableActionsTypeConverter))>
   Partial Class cmisAllowableActionsType
   End Class
End Namespace

Namespace CmisObjectModel.JSON.Core
   <Attributes.AutoGenerated()>
   Partial Public Class cmisAllowableActionsTypeConverter
      Inherits JSON.Serialization.Generic.JavaScriptConverter(Of CmisObjectModel.Core.cmisAllowableActionsType)

#Region "Constructors"
      Public Sub New()
         MyBase.New(New JSON.Serialization.Generic.DefaultObjectResolver(Of CmisObjectModel.Core.cmisAllowableActionsType))
      End Sub
      Public Sub New(objectResolver As Serialization.Generic.ObjectResolver(Of CmisObjectModel.Core.cmisAllowableActionsType))
         MyBase.New(objectResolver)
      End Sub
#End Region

      Protected Overloads Overrides Sub Deserialize(context As SerializationContext)
         With context
            .Object.CanDeleteObject = ReadNullable(.Dictionary, "canDeleteObject", .Object.CanDeleteObject)
            .Object.CanUpdateProperties = ReadNullable(.Dictionary, "canUpdateProperties", .Object.CanUpdateProperties)
            .Object.CanGetFolderTree = ReadNullable(.Dictionary, "canGetFolderTree", .Object.CanGetFolderTree)
            .Object.CanGetProperties = ReadNullable(.Dictionary, "canGetProperties", .Object.CanGetProperties)
            .Object.CanGetObjectRelationships = ReadNullable(.Dictionary, "canGetObjectRelationships", .Object.CanGetObjectRelationships)
            .Object.CanGetObjectParents = ReadNullable(.Dictionary, "canGetObjectParents", .Object.CanGetObjectParents)
            .Object.CanGetFolderParent = ReadNullable(.Dictionary, "canGetFolderParent", .Object.CanGetFolderParent)
            .Object.CanGetDescendants = ReadNullable(.Dictionary, "canGetDescendants", .Object.CanGetDescendants)
            .Object.CanMoveObject = ReadNullable(.Dictionary, "canMoveObject", .Object.CanMoveObject)
            .Object.CanDeleteContentStream = ReadNullable(.Dictionary, "canDeleteContentStream", .Object.CanDeleteContentStream)
            .Object.CanCheckOut = ReadNullable(.Dictionary, "canCheckOut", .Object.CanCheckOut)
            .Object.CanCancelCheckOut = ReadNullable(.Dictionary, "canCancelCheckOut", .Object.CanCancelCheckOut)
            .Object.CanCheckIn = ReadNullable(.Dictionary, "canCheckIn", .Object.CanCheckIn)
            .Object.CanSetContentStream = ReadNullable(.Dictionary, "canSetContentStream", .Object.CanSetContentStream)
            .Object.CanGetAllVersions = ReadNullable(.Dictionary, "canGetAllVersions", .Object.CanGetAllVersions)
            .Object.CanAddObjectToFolder = ReadNullable(.Dictionary, "canAddObjectToFolder", .Object.CanAddObjectToFolder)
            .Object.CanRemoveObjectFromFolder = ReadNullable(.Dictionary, "canRemoveObjectFromFolder", .Object.CanRemoveObjectFromFolder)
            .Object.CanGetContentStream = ReadNullable(.Dictionary, "canGetContentStream", .Object.CanGetContentStream)
            .Object.CanApplyPolicy = ReadNullable(.Dictionary, "canApplyPolicy", .Object.CanApplyPolicy)
            .Object.CanGetAppliedPolicies = ReadNullable(.Dictionary, "canGetAppliedPolicies", .Object.CanGetAppliedPolicies)
            .Object.CanRemovePolicy = ReadNullable(.Dictionary, "canRemovePolicy", .Object.CanRemovePolicy)
            .Object.CanGetChildren = ReadNullable(.Dictionary, "canGetChildren", .Object.CanGetChildren)
            .Object.CanCreateDocument = ReadNullable(.Dictionary, "canCreateDocument", .Object.CanCreateDocument)
            .Object.CanCreateFolder = ReadNullable(.Dictionary, "canCreateFolder", .Object.CanCreateFolder)
            .Object.CanCreateRelationship = ReadNullable(.Dictionary, "canCreateRelationship", .Object.CanCreateRelationship)
            .Object.CanDeleteTree = ReadNullable(.Dictionary, "canDeleteTree", .Object.CanDeleteTree)
            .Object.CanGetRenditions = ReadNullable(.Dictionary, "canGetRenditions", .Object.CanGetRenditions)
            .Object.CanGetACL = ReadNullable(.Dictionary, "canGetACL", .Object.CanGetACL)
            .Object.CanApplyACL = ReadNullable(.Dictionary, "canApplyACL", .Object.CanApplyACL)
         End With
      End Sub

      Protected Overloads Overrides Sub Serialize(context As SerializationContext)
         With context
            If .Object.CanDeleteObject.HasValue Then .Add("canDeleteObject", .Object.CanDeleteObject.Value)
            If .Object.CanUpdateProperties.HasValue Then .Add("canUpdateProperties", .Object.CanUpdateProperties.Value)
            If .Object.CanGetFolderTree.HasValue Then .Add("canGetFolderTree", .Object.CanGetFolderTree.Value)
            If .Object.CanGetProperties.HasValue Then .Add("canGetProperties", .Object.CanGetProperties.Value)
            If .Object.CanGetObjectRelationships.HasValue Then .Add("canGetObjectRelationships", .Object.CanGetObjectRelationships.Value)
            If .Object.CanGetObjectParents.HasValue Then .Add("canGetObjectParents", .Object.CanGetObjectParents.Value)
            If .Object.CanGetFolderParent.HasValue Then .Add("canGetFolderParent", .Object.CanGetFolderParent.Value)
            If .Object.CanGetDescendants.HasValue Then .Add("canGetDescendants", .Object.CanGetDescendants.Value)
            If .Object.CanMoveObject.HasValue Then .Add("canMoveObject", .Object.CanMoveObject.Value)
            If .Object.CanDeleteContentStream.HasValue Then .Add("canDeleteContentStream", .Object.CanDeleteContentStream.Value)
            If .Object.CanCheckOut.HasValue Then .Add("canCheckOut", .Object.CanCheckOut.Value)
            If .Object.CanCancelCheckOut.HasValue Then .Add("canCancelCheckOut", .Object.CanCancelCheckOut.Value)
            If .Object.CanCheckIn.HasValue Then .Add("canCheckIn", .Object.CanCheckIn.Value)
            If .Object.CanSetContentStream.HasValue Then .Add("canSetContentStream", .Object.CanSetContentStream.Value)
            If .Object.CanGetAllVersions.HasValue Then .Add("canGetAllVersions", .Object.CanGetAllVersions.Value)
            If .Object.CanAddObjectToFolder.HasValue Then .Add("canAddObjectToFolder", .Object.CanAddObjectToFolder.Value)
            If .Object.CanRemoveObjectFromFolder.HasValue Then .Add("canRemoveObjectFromFolder", .Object.CanRemoveObjectFromFolder.Value)
            If .Object.CanGetContentStream.HasValue Then .Add("canGetContentStream", .Object.CanGetContentStream.Value)
            If .Object.CanApplyPolicy.HasValue Then .Add("canApplyPolicy", .Object.CanApplyPolicy.Value)
            If .Object.CanGetAppliedPolicies.HasValue Then .Add("canGetAppliedPolicies", .Object.CanGetAppliedPolicies.Value)
            If .Object.CanRemovePolicy.HasValue Then .Add("canRemovePolicy", .Object.CanRemovePolicy.Value)
            If .Object.CanGetChildren.HasValue Then .Add("canGetChildren", .Object.CanGetChildren.Value)
            If .Object.CanCreateDocument.HasValue Then .Add("canCreateDocument", .Object.CanCreateDocument.Value)
            If .Object.CanCreateFolder.HasValue Then .Add("canCreateFolder", .Object.CanCreateFolder.Value)
            If .Object.CanCreateRelationship.HasValue Then .Add("canCreateRelationship", .Object.CanCreateRelationship.Value)
            If .Object.CanDeleteTree.HasValue Then .Add("canDeleteTree", .Object.CanDeleteTree.Value)
            If .Object.CanGetRenditions.HasValue Then .Add("canGetRenditions", .Object.CanGetRenditions.Value)
            If .Object.CanGetACL.HasValue Then .Add("canGetACL", .Object.CanGetACL.Value)
            If .Object.CanApplyACL.HasValue Then .Add("canApplyACL", .Object.CanApplyACL.Value)
         End With
      End Sub
   End Class
End Namespace