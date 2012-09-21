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

namespace OpenADK.Library.us.Programs{

/// <summary>Category represents the educational setting in which children with disabilities have been placed (setting where child has most desirable learning environment).  Primarily used for IDEA federal reporting.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class ServiceSetting : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ServiceSetting
	/// </summary>
	public ServiceSetting() : base ( ProgramsDTD.SERVICESETTING ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="codeType">If CodeType = "NCES" Then use Code set 0307 Service Setting [NCES Handbooks]</param>
	///<param name="code">Setting where service is provided (Regular Class, Resource Room, Homebound, Detention Center, etc.).</param>
	///
	public ServiceSetting( string codeType, ServiceSettingCode code ) : base( ProgramsDTD.SERVICESETTING )
	{
		this.CodeType = codeType;
		this.SetCode( code );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ServiceSetting( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ProgramsDTD.SERVICESETTING_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>CodeType</c> attribute.
	/// </summary>
	/// <value> The <c>CodeType</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "If CodeType = "NCES" Then use Code set 0307 Service Setting [NCES Handbooks]"</para>
	/// <para>Version: 1.5r1</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string CodeType
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.SERVICESETTING_CODETYPE ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.SERVICESETTING_CODETYPE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Setting where service is provided (Regular Class, Resource Room, Homebound, Detention Center, etc.)."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( ProgramsDTD.SERVICESETTING_CODE );
		}
		set
		{
			SetField( ProgramsDTD.SERVICESETTING_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A ServiceSettingCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Setting where service is provided (Regular Class, Resource Room, Homebound, Detention Center, etc.)."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetCode( ServiceSettingCode val )
	{
		SetField( ProgramsDTD.SERVICESETTING_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( ProgramsDTD.SERVICESETTING_OTHERCODELIST);
		}
		set
		{
			RemoveChild( ProgramsDTD.SERVICESETTING_OTHERCODELIST);
			if( value != null)
			{
				AddChild( ProgramsDTD.SERVICESETTING_OTHERCODELIST, value );
			}
		}
	}

}}