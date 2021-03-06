// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Gradebook{

/// <summary>An AuditInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class AuditInfo : SifElement
{
	/// <summary>
	/// Creates an instance of an AuditInfo
	/// </summary>
	public AuditInfo() : base ( GradebookDTD.AUDITINFO ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AuditInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Sets the value of the <c>&lt;CreationUser&gt;</c> element.</summary>
	/// <param name="Type">The role of the staff member for that created this attendance record.</param>
	/// <param name="UserId">Unique identifier of the user that created the attendance record.  This will depend on the user and the source.  The preferred identifier would be a RefId for a StaffPersonal, StudentContact, or StudentPersonal Object.  However, the user may not be associated with any of these SIF objects.  In that case a unique ID given by the source should be used.</param>
	///<remarks>
	/// <para>This form of <c>setCreationUser</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>CreationUser</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCreationUser( AuditInfoType Type, string UserId ) {
		RemoveChild( GradebookDTD.AUDITINFO_CREATIONUSER);
		AddChild( GradebookDTD.AUDITINFO_CREATIONUSER, new CreationUser( Type, UserId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CreationUser&gt;</c> element.
	/// </summary>
	/// <value> A CreationUser </value>
	/// <remarks>
	/// <para>To remove the <c>CreationUser</c>, set <c>CreationUser</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public CreationUser CreationUser
	{
		get
		{
			return (CreationUser)GetChild( GradebookDTD.AUDITINFO_CREATIONUSER);
		}
		set
		{
			RemoveChild( GradebookDTD.AUDITINFO_CREATIONUSER);
			if( value != null)
			{
				AddChild( GradebookDTD.AUDITINFO_CREATIONUSER, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CreationDateTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>CreationDateTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date and time of this attendance record was created."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? CreationDateTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( GradebookDTD.AUDITINFO_CREATIONDATETIME ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.AUDITINFO_CREATIONDATETIME, new SifDateTime( value ), value );
		}
	}

}}
