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

namespace OpenADK.Library.au.Common{

/// <summary>An OtherNames</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class OtherNames : SifKeyedList<Name>
{
	/// <summary>
	/// Creates an instance of an OtherNames
	/// </summary>
	public OtherNames() : base ( CommonDTD.OTHERNAMES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="name">A Name</param>
	///
	public OtherNames( Name name ) : base( CommonDTD.OTHERNAMES )
	{
		this.SafeAddChild( CommonDTD.OTHERNAMES_NAME, name );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected OtherNames( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.OTHERNAMES_NAME }; }
	}

	///<summary>Adds the value of the <c>&lt;Name&gt;</c> element.</summary>
	/// <param name="Type">
	/// Code that specifies what type of name this is. If
	/// unsure, use LGL.</param>
	///<remarks>
	/// <para>This form of <c>setName</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddName</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void AddName( NameType Type ) {
		AddChild( CommonDTD.OTHERNAMES_NAME, new Name( Type ) );
	}

}}
