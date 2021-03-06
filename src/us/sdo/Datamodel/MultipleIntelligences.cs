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

namespace OpenADK.Library.us.Datamodel{

/// <summary>A MultipleIntelligences</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.2</para>
/// </remarks>
[Serializable]
public class MultipleIntelligences : SifKeyedList<MultipleIntelligence>
{
	/// <summary>
	/// Creates an instance of a MultipleIntelligences
	/// </summary>
	public MultipleIntelligences() : base ( DatamodelDTD.MULTIPLEINTELLIGENCES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="multipleIntelligence">A MultipleIntelligence</param>
	///
	public MultipleIntelligences( MultipleIntelligence multipleIntelligence ) : base( DatamodelDTD.MULTIPLEINTELLIGENCES )
	{
		this.SafeAddChild( DatamodelDTD.MULTIPLEINTELLIGENCES_MULTIPLEINTELLIGENCE, multipleIntelligence );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected MultipleIntelligences( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;MultipleIntelligence&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;MultipleIntelligence&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setMultipleIntelligence</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddMultipleIntelligence</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void AddMultipleIntelligence( MultipleIntelligenceType Value ) {
		AddChild( DatamodelDTD.MULTIPLEINTELLIGENCES_MULTIPLEINTELLIGENCE, new MultipleIntelligence( Value ) );
	}

}}
