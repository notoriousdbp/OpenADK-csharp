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

/// <summary>A JobFunction</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class JobFunction : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a JobFunction
	/// </summary>
	public JobFunction() : base ( CommonDTD.JOBFUNCTION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">Code representing the type of job function.</param>
	///
	public JobFunction( JobFunctionCode code ) : base( CommonDTD.JOBFUNCTION )
	{
		this.SetCode( code );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected JobFunction( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.JOBFUNCTION_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <value> The <c>Code</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Code representing the type of job function."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( CommonDTD.JOBFUNCTION_CODE );
		}
		set
		{
			SetField( CommonDTD.JOBFUNCTION_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <param name="val">A JobFunctionCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Code representing the type of job function."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetCode( JobFunctionCode val )
	{
		SetField( CommonDTD.JOBFUNCTION_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( CommonDTD.JOBFUNCTION_OTHERCODELIST);
		}
		set
		{
			RemoveChild( CommonDTD.JOBFUNCTION_OTHERCODELIST);
			if( value != null)
			{
				AddChild( CommonDTD.JOBFUNCTION_OTHERCODELIST, value );
			}
		}
	}

		///<summary>Returns the value of the <c>Code</c> attribute</summary>
		public override string ToString() {
			return this.Code;
	}

}}
