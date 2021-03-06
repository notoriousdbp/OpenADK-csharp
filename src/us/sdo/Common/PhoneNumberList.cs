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

namespace OpenADK.Library.us.Common{

/// <summary>A PhoneNumberList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class PhoneNumberList : SifActionList<PhoneNumber>
{
	/// <summary>
	/// Creates an instance of a PhoneNumberList
	/// </summary>
	public PhoneNumberList() : base ( CommonDTD.PHONENUMBERLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="phoneNumber">This element contains the employee's phone number.For a description of this element, see 5.1.22 PhoneNumber.</param>
	///
	public PhoneNumberList( PhoneNumber phoneNumber ) : base( CommonDTD.PHONENUMBERLIST )
	{
		this.SafeAddChild( CommonDTD.PHONENUMBERLIST_PHONENUMBER, phoneNumber );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PhoneNumberList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;PhoneNumber&gt;</c> element.</summary>
	/// <param name="Type">Code that specifies what type of phone number this is.  Note: A subset of valid values may be specified in data objects.</param>
	/// <param name="Number">Phone number.  Acceptable formats:</param>
	///<remarks>
	/// <para>This form of <c>setPhoneNumber</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddPhoneNumber</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void AddPhoneNumber( PhoneNumberType Type, string Number ) {
		AddChild( CommonDTD.PHONENUMBERLIST_PHONENUMBER, new PhoneNumber( Type, Number ) );
	}

}}
