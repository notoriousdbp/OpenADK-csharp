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

namespace OpenADK.Library.uk.Learner{

/// <summary>A list of Special Educational Needs types for this learner. Note that each SEN type must have its own unique ranking, and all rankings must be consecutive starting with 1.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class SENTypeList : SifKeyedList<SENType>
{
	/// <summary>
	/// Creates an instance of a SENTypeList
	/// </summary>
	public SENTypeList() : base ( LearnerDTD.SENTYPELIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="senType">A SENType</param>
	///
	public SENTypeList( SENType senType ) : base( LearnerDTD.SENTYPELIST )
	{
		this.SafeAddChild( LearnerDTD.SENTYPELIST_SENTYPE, senType );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SENTypeList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;SENType&gt;</c> element.</summary>
	/// <param name="Ranking">A value (starting at 1) indicating the order of significance of special educational need in relation to other SEN types listed here. CBDS: 100080</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;SENType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setSENType</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSENType</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddSENType( int? Ranking, SENTypeCode Value ) {
		AddChild( LearnerDTD.SENTYPELIST_SENTYPE, new SENType( Ranking, Value ) );
	}

}}
