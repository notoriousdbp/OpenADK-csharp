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

/// <summary>An OtherCodeList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class OtherCodeList : SifKeyedList<OtherCode>
{
	/// <summary>
	/// Creates an instance of an OtherCodeList
	/// </summary>
	public OtherCodeList() : base ( CommonDTD.OTHERCODELIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="otherCode">A state/province code, local code, other code or a text string
	/// that crosswalks to or serves as a translation of an associated Code
	/// element.</param>
	///
	public OtherCodeList( OtherCode otherCode ) : base( CommonDTD.OTHERCODELIST )
	{
		this.SafeAddChild( CommonDTD.OTHERCODELIST_OTHERCODE, otherCode );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected OtherCodeList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;OtherCode&gt;</c> element.</summary>
	/// <param name="Codeset">Describes the OtherCode element content as either a
	/// state/province code, a local code, other code, or text string.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;OtherCode&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setOtherCode</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddOtherCode</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddOtherCode( Codeset Codeset, string Value ) {
		AddChild( CommonDTD.OTHERCODELIST_OTHERCODE, new OtherCode( Codeset, Value ) );
	}

}}