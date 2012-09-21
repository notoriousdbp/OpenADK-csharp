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
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.Assessment{

/// <summary>An AssessmentResultComponentGroup</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.1</para>
/// </remarks>
[Serializable]
public class AssessmentResultComponentGroup : SifDataObject
{
	/// <summary>
	/// Creates an instance of an AssessmentResultComponentGroup
	/// </summary>
	public AssessmentResultComponentGroup() : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The ID (GUID) that uniquely identifies a component group.</param>
	///<param name="name">Name of the assessment/test/goal.</param>
	///<param name="componentList">A ComponentList</param>
	///
	public AssessmentResultComponentGroup( string refId, string name, AssessmentResultComponentList componentList ) : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP )
	{
		this.RefId = refId;
		this.Name = name;
		this.ComponentList = componentList;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentResultComponentGroup( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies a component group."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of the assessment/test/goal."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_NAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_NAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The identifier used for this entity within the publishing application."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_LOCALID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SupplierName&gt;</c> element.
	/// </summary>
	/// <value> The <c>SupplierName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The supplier/originator/designer/owner of the described component grouping."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public string SupplierName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_SUPPLIERNAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_SUPPLIERNAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ComponentList&gt;</c> element.</summary>
	/// <param name="AssessmentResultComponentRefId">A SIF identifier for an assessment result component.</param>
	///<remarks>
	/// <para>This form of <c>setComponentList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ComponentList</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public void SetComponentList( AssessmentResultComponentRefId AssessmentResultComponentRefId ) {
		RemoveChild( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_COMPONENTLIST);
		AddChild( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_COMPONENTLIST, new AssessmentResultComponentList( AssessmentResultComponentRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ComponentList&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentResultComponentList </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentResultComponentList</c>, set <c>ComponentList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public AssessmentResultComponentList ComponentList
	{
		get
		{
			return (AssessmentResultComponentList)GetChild( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_COMPONENTLIST);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_COMPONENTLIST);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTRESULTCOMPONENTGROUP_COMPONENTLIST, value );
			}
		}
	}

}}