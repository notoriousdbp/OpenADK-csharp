// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using OpenADK.Util;
using OpenADK.Library;
using OpenADK.Library.Impl;
using CommonDTD = OpenADK.Library.uk.Common.CommonDTD;
using ReportingDTD = OpenADK.Library.uk.Reporting.ReportingDTD;

namespace OpenADK.Library.uk.Infrastructure
{

// BEGIN FILE... (SIFDTD_Comments_CS.txt)

/// <summary>Metadata for the Schools Interoperability Framework (SIF)</summary>
	/// <remarks>
	/// <para>
	/// SIFDTD defines global {@linkplain com.edustructures.sifworks.ElementDef} 
	/// constants that describe SIF Data Objects, elements, and attributes across all 
	/// supported versions of the SIF Specification. The ADK uses this metadata 
	/// internally to parse and render SIF Data Objects.  In addition, many of the 
	/// framework APIs require that the programmer pass an ElementDef constant from 
	/// the SIFDTD class to identify an object, element, or attribute.
	/// </para>
	/// <para>
	/// ElementDef constants are named <c>[PARENT_]ENTITY</c>, where 
	/// <c>PARENT</c> is the name of the parent element and 
	/// <c>ENTITY</c> is the name of the element or attribute 
	/// encapsulated by the ElementDef. Some examples of ElementDef constants defined
	/// by this class include:
	/// </para>
	/// <list type="table">
	/// <listheader><term>IElementDef</term><description>Description</description></listheader>
	/// <item><term><c>SIFDTD.STUDENTPERSONAL</c></term><description>Identifies the StudentPersonal data object</description></item>
	/// <item><term><c>SIFDTD.SCHOOLINFO</c></term><description>Identifies the SchoolInfo data object</description></item>
	/// </list>
	/// Many of the Adk's public interfaces require an ElementDef constant to be passed
	/// as a parameter. For example, the first parameter to the <see cref="IZone.SetSubscriber"/>
	/// method is an IElementDef:
	/// <code>myZone.setSubscriber( SIFDTD.BUSINFO, this, ADKFlags.PROV_SUBSCRIBE );</code>
	/// ElementDef also identifies child elements and attributes as demonstrated by the	<c>Query.AddCondition</c> method:
	/// <code>
	/// Query query = new Query( SifDtd.STUDENTPERSONAL );
	/// query.AddCondition( SifDtd.STUDENTPERSONAL_REFID, Condition.EQ, "4A37969803F0D00322AF0EB969038483" );
	/// </code>
	/// <para>
	/// <b>SDO Libraries</b>
	/// </para>
	/// <para>
	/// ElementDef metadata is grouped into "SDO Libraries", which are organized along 
	/// SIF Working Group boundaries. SDO Libraries are loaded into the <c>SifDdt</c> 
	/// class when the Adk is initialized. All or part of the metadata is loaded into depending on the flags passed to the
	/// <see cref="Adk.Initialize(SifVersion, SdoLibraryType)"/> method,
	/// metadata from one or more SDO Libraries may be loaded. For example, the following
	/// call loads metadata for the <c>Student Information Working Group Objects</c>  
	/// and <c>Transportation And Geographic Information Working Group Objects</c> 
	/// (Common Elements and <c>Infrastructure Working Group Objects</c> metadata is always loaded
	/// </para>
	/// <code>Adk.Initialize( SiFVersion.LATEST, SdoLibraryType.Student | SdoLibraryType.Trans )</code>
	/// <para>
	/// If an given SDO Library is not loaded, all of the SIFDTD constants that belong
	/// to that library will be <code>null</code> and cannot be referenced. For example,
	/// given the SDO Libraries loaded above, attempting to reference the 
	/// <code>SIFDTD.LIBRARYPATRONSTATUS</code> object from the Library Automation Working
	/// Group would result in a NullPointerException:
	/// </para>
	/// <code>SifDtd.LIBRARYPATRONSTATUS.Name;</code>
	/// </remarks>
	public class InfrastructureDTD : OpenADK.Library.Impl.SdoLibraryImpl
	{
	/** Defines the &lt;Identity&gt; SIF Data Object */
	public static IElementDef IDENTITY = null;
	/** Defines the &lt;IdentityAssertion&gt; SIF Data Object */
	public static IElementDef IDENTITYASSERTION = null;
	/** Defines the &lt;IdentityAssertions&gt; SIF Data Object */
	public static IElementDef IDENTITYASSERTIONS = null;
	/** Defines the &lt;PasswordList&gt; SIF Data Object */
	public static IElementDef PASSWORDLIST = null;


	// Field elements of IDENTITY (6 fields)
	/** Defines the RefId attribute as a child of &lt;Identity&gt; */
	public static IElementDef IDENTITY_REFID = null;
	/** Defines the &lt;SIF_RefId&gt; element as a child of &lt;Identity&gt; */
	public static IElementDef IDENTITY_SIF_REFID = null;
	/** Defines the &lt;AuthenticationSource&gt; element as a child of &lt;Identity&gt; */
	public static IElementDef IDENTITY_AUTHENTICATIONSOURCE = null;
	/** Defines the &lt;IdentityAssertions&gt; element as a child of &lt;Identity&gt; */
	public static IElementDef IDENTITY_IDENTITYASSERTIONS = null;
	/** Defines the &lt;PasswordList&gt; element as a child of &lt;Identity&gt; */
	public static IElementDef IDENTITY_PASSWORDLIST = null;
	/** Defines the &lt;AuthenticationSourceGlobalUID&gt; element as a child of &lt;Identity&gt; */
	public static IElementDef IDENTITY_AUTHENTICATIONSOURCEGLOBALUID = null;
	/** SIF 1.5 and later: Defines the built-in SIF_ExtendedElements element common to all SIF Data Objects */
	public static IElementDef IDENTITY_SIF_EXTENDEDELEMENTS = null;
	/** SIF 2.0 and later: Defines the built-in SIF_Metadata element common to all SIF Data Objects */
	public static IElementDef IDENTITY_SIF_METADATA = null;

	// Field elements of IDENTITYASSERTION (1 fields)
	/** Defines the SchemaName attribute as a child of &lt;IdentityAssertion&gt; */
	public static IElementDef IDENTITYASSERTION_SCHEMANAME = null;

	// Field elements of IDENTITYASSERTIONS (1 fields)
	/** Defines the &lt;IdentityAssertion&gt; element as a child of &lt;IdentityAssertions&gt; */
	public static IElementDef IDENTITYASSERTIONS_IDENTITYASSERTION = null;

	// Field elements of PASSWORDLIST (1 fields)
	/** Defines the &lt;Password&gt; element as a child of &lt;PasswordList&gt; */
	public static IElementDef PASSWORDLIST_PASSWORD = null;

	public override void Load()
	{
		//  Objects defined by this SDO Library...

		IDENTITY = new ElementDefImpl( null, "Identity", null, 0, SifDtd.INFRASTRUCTURE, "uk", (ElementDefImpl.FD_OBJECT), SifVersion.SIF21, SifVersion.SIF25 );
		IDENTITYASSERTION = new ElementDefImpl( null, "IdentityAssertion", null, 0, SifDtd.INFRASTRUCTURE, "uk", 0, SifVersion.SIF21, SifVersion.SIF25, SifTypeConverters.STRING );
		IDENTITYASSERTIONS = new ElementDefImpl( null, "IdentityAssertions", null, 0, SifDtd.INFRASTRUCTURE, "uk", 0, SifVersion.SIF21, SifVersion.SIF25 );
		PASSWORDLIST = new ElementDefImpl( null, "PasswordList", null, 0, SifDtd.INFRASTRUCTURE, "uk", 0, SifVersion.SIF21, SifVersion.SIF25 );


		// <Identity> fields (6 entries)
		InfrastructureDTD.IDENTITY_REFID = new ElementDefImpl( IDENTITY, "RefId", null, 1, SifDtd.INFRASTRUCTURE, "uk", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF21, SifVersion.SIF25, SifTypeConverters.STRING );
		InfrastructureDTD.IDENTITY_SIF_REFID = new ElementDefImpl( IDENTITY, "SIF_RefId", null, 2, SifDtd.GLOBAL, null, 0, SifVersion.SIF21, SifVersion.SIF25, SifTypeConverters.STRING );
		InfrastructureDTD.IDENTITY_AUTHENTICATIONSOURCE = new ElementDefImpl( IDENTITY, "AuthenticationSource", null, 3, SifDtd.INFRASTRUCTURE, "uk", (ElementDefImpl.FD_FIELD), SifVersion.SIF21, SifVersion.SIF25, SifTypeConverters.STRING );
		InfrastructureDTD.IDENTITY_IDENTITYASSERTIONS = new ElementDefImpl( IDENTITY, "IdentityAssertions", null, 4, SifDtd.INFRASTRUCTURE, "uk", 0, SifVersion.SIF21, SifVersion.SIF25 );
		InfrastructureDTD.IDENTITY_PASSWORDLIST = new ElementDefImpl( IDENTITY, "PasswordList", null, 5, SifDtd.INFRASTRUCTURE, "uk", 0, SifVersion.SIF21, SifVersion.SIF25 );
		InfrastructureDTD.IDENTITY_AUTHENTICATIONSOURCEGLOBALUID = new ElementDefImpl( IDENTITY, "AuthenticationSourceGlobalUID", null, 6, SifDtd.INFRASTRUCTURE, "uk", (ElementDefImpl.FD_FIELD), SifVersion.SIF23, SifVersion.SIF25, SifTypeConverters.STRING );
		IDENTITY_SIF_EXTENDEDELEMENTS = new ElementDefImpl( IDENTITY, "SIF_ExtendedElements", null, 127, SifDtd.GLOBAL, null, (0), SifVersion.SIF15r1, SifVersion.SIF25 );
		IDENTITY_SIF_METADATA = new ElementDefImpl( IDENTITY, "SIF_Metadata", null, 128, SifDtd.DATAMODEL, "uk", (0), SifVersion.SIF20, SifVersion.SIF25 );

		// <IdentityAssertion> fields (1 entries)
		InfrastructureDTD.IDENTITYASSERTION_SCHEMANAME = new ElementDefImpl( IDENTITYASSERTION, "SchemaName", null, 1, SifDtd.INFRASTRUCTURE, "uk", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF21, SifVersion.SIF25, SifTypeConverters.STRING );

		// <IdentityAssertions> fields (1 entries)
		InfrastructureDTD.IDENTITYASSERTIONS_IDENTITYASSERTION = new ElementDefImpl( IDENTITYASSERTIONS, "IdentityAssertion", null, 1, SifDtd.INFRASTRUCTURE, "uk", (ElementDefImpl.FD_REPEATABLE), SifVersion.SIF21, SifVersion.SIF25, SifTypeConverters.STRING );

		// <PasswordList> fields (1 entries)
		InfrastructureDTD.PASSWORDLIST_PASSWORD = new ElementDefImpl( PASSWORDLIST, "Password", null, 1, SifDtd.INFRA, null, (ElementDefImpl.FD_REPEATABLE), SifVersion.SIF21, SifVersion.SIF25, SifTypeConverters.STRING );
	}

	#region Update SifDtd
	public override void AddElementMappings( IDictionary<String, IElementDef> dictionary )
	{
		dictionary[ "IdentityAssertion" ] = IDENTITYASSERTION;
		dictionary["IdentityAssertion_SchemaName"] = InfrastructureDTD.IDENTITYASSERTION_SCHEMANAME ;
		dictionary[ "IdentityAssertions" ] = IDENTITYASSERTIONS;
		dictionary["IdentityAssertions_IdentityAssertion"] = InfrastructureDTD.IDENTITYASSERTIONS_IDENTITYASSERTION ;
		dictionary[ "PasswordList" ] = PASSWORDLIST;
		dictionary["PasswordList_Password"] = InfrastructureDTD.PASSWORDLIST_PASSWORD ;
		dictionary[ "Identity" ] = IDENTITY;
		dictionary[ "Identity_SIF_ExtendedElements" ] = IDENTITY_SIF_EXTENDEDELEMENTS ;
		dictionary[ "Identity_SIF_Metadata" ] = IDENTITY_SIF_METADATA;
		dictionary["Identity_AuthenticationSource"] = InfrastructureDTD.IDENTITY_AUTHENTICATIONSOURCE ;
		dictionary["Identity_AuthenticationSourceGlobalUID"] = InfrastructureDTD.IDENTITY_AUTHENTICATIONSOURCEGLOBALUID ;
		dictionary["Identity_IdentityAssertions"] = InfrastructureDTD.IDENTITY_IDENTITYASSERTIONS ;
		dictionary["Identity_PasswordList"] = InfrastructureDTD.IDENTITY_PASSWORDLIST ;
		dictionary["Identity_RefId"] = InfrastructureDTD.IDENTITY_REFID ;
		dictionary["Identity_SIF_RefId"] = InfrastructureDTD.IDENTITY_SIF_REFID ;
	}
	#endregion
}}