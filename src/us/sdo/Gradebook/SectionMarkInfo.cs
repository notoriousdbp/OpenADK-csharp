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

namespace OpenADK.Library.us.Gradebook{

/// <summary>A SectionMarkInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class SectionMarkInfo : SifDataObject
{
	/// <summary>
	/// Creates an instance of a SectionMarkInfo
	/// </summary>
	public SectionMarkInfo() : base( Adk.SifVersion, GradebookDTD.SECTIONMARKINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sectionInfoRefId">The ID (GUID) that uniquely identifies the SectionInfo object that this item refers to.</param>
	///<param name="schoolInfoRefId">The ID (GUID) that uniquely identifies the School that these Mark Values apply to.</param>
	///<param name="termMarkLists">A TermMarkLists</param>
	///
	public SectionMarkInfo( string sectionInfoRefId, string schoolInfoRefId, MarkInfoList termMarkLists ) : base( Adk.SifVersion, GradebookDTD.SECTIONMARKINFO )
	{
		this.SectionInfoRefId = sectionInfoRefId;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.TermMarkLists =  new TermMarkLists( termMarkLists );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SectionMarkInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { GradebookDTD.SECTIONMARKINFO_SECTIONINFOREFID, GradebookDTD.SECTIONMARKINFO_SCHOOLINFOREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>SectionInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SectionInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies the SectionInfo object that this item refers to."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SectionInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.SECTIONMARKINFO_SECTIONINFOREFID ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.SECTIONMARKINFO_SECTIONINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies the School that these Mark Values apply to."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.SECTIONMARKINFO_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.SECTIONMARKINFO_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;TermMarkLists&gt;</c> element.</summary>
	/// <param name="MarkInfoList">A MarkInfoList</param>
	///<remarks>
	/// <para>This form of <c>setTermMarkLists</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>TermMarkLists</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetTermMarkLists( MarkInfoList MarkInfoList ) {
		RemoveChild( GradebookDTD.SECTIONMARKINFO_TERMMARKLISTS);
		AddChild( GradebookDTD.SECTIONMARKINFO_TERMMARKLISTS, new TermMarkLists( MarkInfoList ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TermMarkLists&gt;</c> element.
	/// </summary>
	/// <value> A TermMarkLists </value>
	/// <remarks>
	/// <para>To remove the <c>TermMarkLists</c>, set <c>TermMarkLists</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public TermMarkLists TermMarkLists
	{
		get
		{
			return (TermMarkLists)GetChild( GradebookDTD.SECTIONMARKINFO_TERMMARKLISTS);
		}
		set
		{
			RemoveChild( GradebookDTD.SECTIONMARKINFO_TERMMARKLISTS);
			if( value != null)
			{
				AddChild( GradebookDTD.SECTIONMARKINFO_TERMMARKLISTS, value );
			}
		}
	}

}}