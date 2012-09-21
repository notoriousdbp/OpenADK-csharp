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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Learning{

/// <summary>An Organizations</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class Organizations : SifKeyedList<Organization>
{
	/// <summary>
	/// Creates an instance of an Organizations
	/// </summary>
	public Organizations() : base ( LearningDTD.ORGANIZATIONS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="organization">An Organization</param>
	///
	public Organizations( Organization organization ) : base( LearningDTD.ORGANIZATIONS )
	{
		this.SafeAddChild( LearningDTD.ORGANIZATIONS_ORGANIZATION, organization );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Organizations( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { LearningDTD.ORGANIZATIONS_ORGANIZATION }; }
	}

	///<summary>Adds the value of the <c>&lt;Organization&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Organization&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setOrganization</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddOrganization</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void AddOrganization( string Value ) {
		AddChild( LearningDTD.ORGANIZATIONS_ORGANIZATION, new Organization( Value ) );
	}

}}