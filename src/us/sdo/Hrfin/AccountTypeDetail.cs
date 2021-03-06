// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Hrfin
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AccountTypeDetail
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AccountTypeDetail object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class AccountTypeDetail : SifEnum
	{
	/// <summary>Long Term Liability ("LongTermLiability")</summary>
	public static readonly AccountTypeDetail LONG_TERM_LIABILITY = new AccountTypeDetail("LongTermLiability");

	/// <summary>Other Asset ("OtherAsset")</summary>
	public static readonly AccountTypeDetail OTHER_ASSET = new AccountTypeDetail("OtherAsset");

	/// <summary>Current Asset ("CurrentAsset")</summary>
	public static readonly AccountTypeDetail CURRENT_ASSET = new AccountTypeDetail("CurrentAsset");

	/// <summary>Fund Balance ("FundBalance")</summary>
	public static readonly AccountTypeDetail FUND_BALANCE = new AccountTypeDetail("FundBalance");

	/// <summary>Other Liability ("OtherLiability")</summary>
	public static readonly AccountTypeDetail OTHER_LIABILITY = new AccountTypeDetail("OtherLiability");

	/// <summary>Long Term Asset ("LongTermAsset")</summary>
	public static readonly AccountTypeDetail LONG_TERM_ASSET = new AccountTypeDetail("LongTermAsset");

	/// <summary>Current Liability ("CurrentLiability")</summary>
	public static readonly AccountTypeDetail CURRENT_LIABILITY = new AccountTypeDetail("CurrentLiability");

	///<summary>Wrap an arbitrary string value in an AccountTypeDetail object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AccountTypeDetail Wrap( String wrappedValue ) {
		return new AccountTypeDetail( wrappedValue );
	}

	private AccountTypeDetail( string enumDefValue ) : base( enumDefValue ) {}
	}
}
