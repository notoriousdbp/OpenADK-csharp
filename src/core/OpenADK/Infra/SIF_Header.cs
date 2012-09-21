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

/// <summary>Common message header for all SIF messages</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_Header : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SIF_Header
	/// </summary>
	public SIF_Header() : base ( InfraDTD.SIF_HEADER ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifMsgId">SIF_MsgId is a globally unique message identifier from the Agent or ZIS that sends out the message.</param>
	///<param name="sifTimestamp">Timestamp of when the message was sent.</param>
	///<param name="sifSourceId">The SIF_SourceId is the ID of the originator of the message. Each source needs to have a zone unique case-sensitive identifier.</param>
	///
	public SIF_Header( string sifMsgId, DateTime? sifTimestamp, string sifSourceId ) : base( InfraDTD.SIF_HEADER )
	{
		this.SIF_MsgId = sifMsgId;
		this.SIF_Timestamp = sifTimestamp;
		this.SIF_SourceId = sifSourceId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_Header( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_HEADER_SIF_MSGID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_MsgId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_MsgId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "SIF_MsgId is a globally unique message identifier from the Agent or ZIS that sends out the message."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SIF_MsgId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_HEADER_SIF_MSGID ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_HEADER_SIF_MSGID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Timestamp&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Timestamp</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Timestamp of when the message was sent."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;SIF_Timestamp&gt;</description></item>
	/// </list>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public DateTime? SIF_Timestamp
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( InfraDTD.SIF_HEADER_SIF_TIMESTAMP ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_HEADER_SIF_TIMESTAMP, new SifDateTime( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_Security&gt;</c> element.</summary>
	/// <param name="SifSecureChannel">A SIF_SecureChannel</param>
	///<remarks>
	/// <para>This form of <c>setSIF_Security</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_Security</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetSIF_Security( SIF_SecureChannel SifSecureChannel ) {
		RemoveChild( InfraDTD.SIF_HEADER_SIF_SECURITY);
		AddChild( InfraDTD.SIF_HEADER_SIF_SECURITY, new SIF_Security( SifSecureChannel ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Security&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Security </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_Security</c>, set <c>SIF_Security</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Security SIF_Security
	{
		get
		{
			return (SIF_Security)GetChild( InfraDTD.SIF_HEADER_SIF_SECURITY);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_HEADER_SIF_SECURITY);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_HEADER_SIF_SECURITY, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_SourceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_SourceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The SIF_SourceId is the ID of the originator of the message. Each source needs to have a zone unique case-sensitive identifier."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SIF_SourceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_HEADER_SIF_SOURCEID ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_HEADER_SIF_SOURCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_DestinationId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_DestinationId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This element represents the ID of the recipient of the message and may be present as follows:"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SIF_DestinationId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_HEADER_SIF_DESTINATIONID ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_HEADER_SIF_DESTINATIONID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Contexts&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Contexts </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "
	///         Each SIF Context that applies to the message.  If none is specified, the applicable context is Default.
	///         Repeatable for SIF_Events, not repeatable for SIF_Request or SIF_Response.
	///       "</para>
	/// <para>To remove the <c>SIF_Contexts</c>, set <c>SIF_Contexts</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_Contexts SIF_Contexts
	{
		get
		{
			return (SIF_Contexts)GetChild( InfraDTD.SIF_HEADER_SIF_CONTEXTS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_HEADER_SIF_CONTEXTS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_HEADER_SIF_CONTEXTS, value );
			}
		}
	}

}}