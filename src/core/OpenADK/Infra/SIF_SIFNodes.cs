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

namespace OpenADK.Library.Infra{

/// <summary>A SIF_SIFNodes</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_SIFNodes : SifKeyedList<SIF_SIFNode>
{
	/// <summary>
	/// Creates an instance of a SIF_SIFNodes
	/// </summary>
	public SIF_SIFNodes() : base ( InfraDTD.SIF_SIFNODES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifsifNode">A SIF_SIFNode</param>
	///
	public SIF_SIFNodes( SIF_SIFNode sifsifNode ) : base( InfraDTD.SIF_SIFNODES )
	{
		this.SafeAddChild( InfraDTD.SIF_SIFNODES_SIF_SIFNODE, sifsifNode );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_SIFNodes( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;SIF_SIFNode&gt;</c> element.</summary>
	/// <param name="Type">The type of node ("Agent" or "ZIS")</param>
	/// <param name="SifName">The descriptive name of the SIF node (i.e. Ramsey Food Services).</param>
	/// <param name="SifSourceId">The agent or ZIS identifier. This is the same value that the SIF node would place in any SIF_Header that it would create.</param>
	/// <param name="SifMode">Specifies the communication mode (Pull or Push) as chosen by the message sender.</param>
	/// <param name="SifMaxBufferSize">Specifies that the ZIS should never send packets larger than this value. Query responses from other providers are controlled by the SIF_MaxBufferSize attribute in the SIF_Request message.</param>
	/// <param name="SifSleeping">This element shows whether the SIF node is ready to process messages.</param>
	///<remarks>
	/// <para>This form of <c>setSIF_SIFNode</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSIF_SIFNode</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void AddSIF_SIFNode( SIF_SIFNodeType Type, string SifName, string SifSourceId, SIFMode SifMode, int? SifMaxBufferSize, YesNo SifSleeping ) {
		AddChild( InfraDTD.SIF_SIFNODES_SIF_SIFNODE, new SIF_SIFNode( Type, SifName, SifSourceId, SifMode, SifMaxBufferSize, SifSleeping ) );
	}

}}