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

namespace OpenADK.Library.us.Instr{

/// <summary>Integer assigned to each hierarchical level within the CurriculumStructure tree.  The top level is "1".</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class CurriculumHierarchyLevel : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a CurriculumHierarchyLevel
	/// </summary>
	public CurriculumHierarchyLevel() : base ( InstrDTD.CURRICULUMHIERARCHYLEVEL ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="name">Used to describe what role this is serving in the structure. Some curriculum objects describe their levels in terms of programs of study, courses and units. Others use other terms. This attribute names the level of the item.</param>
	///<param name="number">Integer assigned to each hierarchical level within the CurriculumStructure tree. The top level is 1.</param>
	///<param name="description">Used to describe what role this is serving in the structure. Some curriculum objects describe their levels in terms of programs of study, courses and units. Others use other terms.</param>
	///
	public CurriculumHierarchyLevel( string name, int? number, string description ) : base( InstrDTD.CURRICULUMHIERARCHYLEVEL )
	{
		this.Name = name;
		this.Number = number;
		this.Description = description;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected CurriculumHierarchyLevel( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InstrDTD.CURRICULUMHIERARCHYLEVEL_NAME }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Name</c> attribute.
	/// </summary>
	/// <value> The <c>Name</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Used to describe what role this is serving in the structure. Some curriculum objects describe their levels in terms of programs of study, courses and units. Others use other terms. This attribute names the level of the item."</para>
	/// <para>This attribute is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering attributes of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;Name&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.CURRICULUMHIERARCHYLEVEL_NAME ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CURRICULUMHIERARCHYLEVEL_NAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Number&gt;</c> element.
	/// </summary>
	/// <value> The <c>Number</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Integer assigned to each hierarchical level within the CurriculumStructure tree. The top level is 1."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? Number
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( InstrDTD.CURRICULUMHIERARCHYLEVEL_NUMBER ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CURRICULUMHIERARCHYLEVEL_NUMBER, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Description</c> attribute.
	/// </summary>
	/// <value> The <c>Description</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Used to describe what role this is serving in the structure. Some curriculum objects describe their levels in terms of programs of study, courses and units. Others use other terms."</para>
	/// <para>This attribute is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering attributes of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;Description&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.CURRICULUMHIERARCHYLEVEL_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CURRICULUMHIERARCHYLEVEL_DESCRIPTION, new SifString( value ), value );
		}
	}

}}
