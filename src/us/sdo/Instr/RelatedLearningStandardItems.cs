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

namespace OpenADK.Library.us.Instr{

/// <summary>A RelatedLearningStandardItems</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.1</para>
/// </remarks>
[Serializable]
public class RelatedLearningStandardItems : SifKeyedList<RelatedLearningStandardItem>
{
	/// <summary>
	/// Creates an instance of a RelatedLearningStandardItems
	/// </summary>
	public RelatedLearningStandardItems() : base ( InstrDTD.RELATEDLEARNINGSTANDARDITEMS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="learningStandardItemRefId">Links to related LearningStandardDocument</param>
	///
	public RelatedLearningStandardItems( RelatedLearningStandardItem learningStandardItemRefId ) : base( InstrDTD.RELATEDLEARNINGSTANDARDITEMS )
	{
		this.SafeAddChild( InstrDTD.RELATEDLEARNINGSTANDARDITEMS_LEARNINGSTANDARDITEMREFID, learningStandardItemRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected RelatedLearningStandardItems( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;LearningStandardItemRefId&gt;</c> element.</summary>
	/// <param name="RelationshipType">A RelationshipType</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;RelatedLearningStandardItem&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setLearningStandardItemRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddLearningStandardItemRefId</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public void AddLearningStandardItemRefId( string RelationshipType, string Value ) {
		AddChild( InstrDTD.RELATEDLEARNINGSTANDARDITEMS_LEARNINGSTANDARDITEMREFID, new RelatedLearningStandardItem( RelationshipType, Value ) );
	}

}}
