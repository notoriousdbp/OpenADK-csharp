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

/// <summary>A ServiceFundingSources</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class ServiceFundingSources : SifList<ServiceFundingSource>
{
	/// <summary>
	/// Creates an instance of a ServiceFundingSources
	/// </summary>
	public ServiceFundingSources() : base ( CommonDTD.SERVICEFUNDINGSOURCES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="serviceFundingSource">A ServiceFundingSource</param>
	///
	public ServiceFundingSources( ServiceFundingSource serviceFundingSource ) : base( CommonDTD.SERVICEFUNDINGSOURCES )
	{
		this.SafeAddChild( CommonDTD.SERVICEFUNDINGSOURCES_SERVICEFUNDINGSOURCE, serviceFundingSource );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ServiceFundingSources( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
}}