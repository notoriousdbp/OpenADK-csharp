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

/// <summary>A LearningStandardItems</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class LearningStandardItems : SifKeyedList<LearningStandardItemRefId>
{
	/// <summary>
	/// Creates an instance of a LearningStandardItems
	/// </summary>
	public LearningStandardItems() : base ( CommonDTD.LEARNINGSTANDARDITEMS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="learningStandardItemRefId">A LearningStandardItemRefId</param>
	///
	public LearningStandardItems( LearningStandardItemRefId learningStandardItemRefId ) : base( CommonDTD.LEARNINGSTANDARDITEMS )
	{
		this.SafeAddChild( CommonDTD.LEARNINGSTANDARDITEMS_LEARNINGSTANDARDITEMREFID, learningStandardItemRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected LearningStandardItems( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.LEARNINGSTANDARDITEMS_LEARNINGSTANDARDITEMREFID }; }
	}

	///<summary>Adds the value of the <c>&lt;LearningStandardItemRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;LearningStandardItemRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setLearningStandardItemRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddLearningStandardItemRefId</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void AddLearningStandardItemRefId( string Value ) {
		AddChild( CommonDTD.LEARNINGSTANDARDITEMS_LEARNINGSTANDARDITEMREFID, new LearningStandardItemRefId( Value ) );
	}

}}
