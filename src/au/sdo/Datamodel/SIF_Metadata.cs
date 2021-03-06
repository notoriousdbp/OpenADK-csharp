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

namespace OpenADK.Library.au.Datamodel{

/// <summary>A SIF_Metadata</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class SIF_Metadata : SifElement
{
	/// <summary>
	/// Creates an instance of a SIF_Metadata
	/// </summary>
	public SIF_Metadata() : base ( DatamodelDTD.SIF_METADATA ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_Metadata( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;TimeElements&gt;</c> element.
	/// </summary>
	/// <value> A TimeElements </value>
	/// <remarks>
	/// <para>To remove the <c>TimeElements</c>, set <c>TimeElements</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public TimeElements TimeElements
	{
		get
		{
			return (TimeElements)GetChild( DatamodelDTD.SIF_METADATA_TIMEELEMENTS);
		}
		set
		{
			RemoveChild( DatamodelDTD.SIF_METADATA_TIMEELEMENTS);
			if( value != null)
			{
				AddChild( DatamodelDTD.SIF_METADATA_TIMEELEMENTS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LifeCycle&gt;</c> element.
	/// </summary>
	/// <value> A LifeCycle </value>
	/// <remarks>
	/// <para>To remove the <c>LifeCycle</c>, set <c>LifeCycle</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public LifeCycle LifeCycle
	{
		get
		{
			return (LifeCycle)GetChild( DatamodelDTD.SIF_METADATA_LIFECYCLE);
		}
		set
		{
			RemoveChild( DatamodelDTD.SIF_METADATA_LIFECYCLE);
			if( value != null)
			{
				AddChild( DatamodelDTD.SIF_METADATA_LIFECYCLE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RightsElements&gt;</c> element.
	/// </summary>
	/// <value> A RightsElements </value>
	/// <remarks>
	/// <para>To remove the <c>RightsElements</c>, set <c>RightsElements</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public RightsElements RightsElements
	{
		get
		{
			return (RightsElements)GetChild( DatamodelDTD.SIF_METADATA_RIGHTSELEMENTS);
		}
		set
		{
			RemoveChild( DatamodelDTD.SIF_METADATA_RIGHTSELEMENTS);
			if( value != null)
			{
				AddChild( DatamodelDTD.SIF_METADATA_RIGHTSELEMENTS, value );
			}
		}
	}

}}
