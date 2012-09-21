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

namespace OpenADK.Library.uk.Common{

/// <summary>The Name element defines name information for a person and occurs within objects such as WorforcePersonal, LearnerPersonal, ContactPersonal, etc.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Name : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Name
	/// </summary>
	public Name() : base ( CommonDTD.NAME ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">Code that specifies what type of name this is</param>
	///<param name="familyName">Full legal family name. That part of the person's name which is used to describe family, clan, tribal group, or marital association. Note that this element is always required.  However, when associated with a contact it may not be possible to know the family name in which case you should add the available information to the FullName element. CBDS: 100003, 100162, 100288, 100280, 900001</param>
	///<param name="givenName">Full given name (forename) of the person. Note that this element is always required.  However, when associated with a contact it may not be possible to know the given name in which case you should add the available information to the FullName element. CBDS: 100004, 100163, 100164, 100289, 100006, 100281, 900002</param>
	///
	public Name( NameType type, string familyName, string givenName ) : base( CommonDTD.NAME )
	{
		this.SetType( type );
		this.FamilyName = familyName;
		this.GivenName = givenName;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Name( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.NAME_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Code that specifies what type of name this is"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( CommonDTD.NAME_TYPE );
		}
		set
		{
			SetField( CommonDTD.NAME_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <param name="val">A NameType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Code that specifies what type of name this is"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetType( NameType val )
	{
		SetField( CommonDTD.NAME_TYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Title&gt;</c> element.
	/// </summary>
	/// <value> The <c>Title</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A title or prefix associated with the name.  If any of: Mr, Mrs, Ms, Miss, Rev, Fr, Dr, Prof, Hon, Sir, Lord, Lady - these must be as shown, otherwise free text.  Note that title is not applicable to learners. CBDS: 100161"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Title
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.NAME_TITLE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.NAME_TITLE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FamilyName&gt;</c> element.
	/// </summary>
	/// <value> The <c>FamilyName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Full legal family name. That part of the person's name which is used to describe family, clan, tribal group, or marital association. Note that this element is always required.  However, when associated with a contact it may not be possible to know the family name in which case you should add the available information to the FullName element. CBDS: 100003, 100162, 100288, 100280, 900001"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string FamilyName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.NAME_FAMILYNAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.NAME_FAMILYNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GivenName&gt;</c> element.
	/// </summary>
	/// <value> The <c>GivenName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Full given name (forename) of the person. Note that this element is always required.  However, when associated with a contact it may not be possible to know the given name in which case you should add the available information to the FullName element. CBDS: 100004, 100163, 100164, 100289, 100006, 100281, 900002"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string GivenName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.NAME_GIVENNAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.NAME_GIVENNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MiddleNames&gt;</c> element.
	/// </summary>
	/// <value> The <c>MiddleNames</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "All other given or middle names, each separated with a single space character. CBDS: 100006, 100164"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string MiddleNames
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.NAME_MIDDLENAMES ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.NAME_MIDDLENAMES, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FamilyNameFirst&gt;</c> element.
	/// </summary>
	/// <value> The <c>FamilyNameFirst</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indicator used to identify the naming conventions used by some predominantly non-European, ethnic or language groups and related to the display nature of a name.. CBDS: 100282, 900003"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string FamilyNameFirst
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.NAME_FAMILYNAMEFIRST ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.NAME_FAMILYNAMEFIRST, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PreferredFamilyName&gt;</c> element.
	/// </summary>
	/// <value> The <c>PreferredFamilyName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The family name preferred most by the person (as written). CBDS: 100011, 100285, 900006"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string PreferredFamilyName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.NAME_PREFERREDFAMILYNAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.NAME_PREFERREDFAMILYNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PreferredFamilyNameFirst&gt;</c> element.
	/// </summary>
	/// <value> The <c>PreferredFamilyNameFirst</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indicator used to identify the naming conventions used by some predominantly non-European, ethnic or language groups and related to the display nature of a name.. CBDS: 100012, 100286, 900007"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string PreferredFamilyNameFirst
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.NAME_PREFERREDFAMILYNAMEFIRST ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.NAME_PREFERREDFAMILYNAMEFIRST, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PreferredGivenName&gt;</c> element.
	/// </summary>
	/// <value> The <c>PreferredGivenName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The given name preferred most by the person (as written). CBDS: 100010, 100284, 900005"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string PreferredGivenName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.NAME_PREFERREDGIVENNAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.NAME_PREFERREDGIVENNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Suffix&gt;</c> element.
	/// </summary>
	/// <value> The <c>Suffix</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Textual suffix like PHD, JP, BSc."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Suffix
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.NAME_SUFFIX ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.NAME_SUFFIX, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FullName&gt;</c> element.
	/// </summary>
	/// <value> The <c>FullName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A free text field for the complete name for display purposes."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string FullName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.NAME_FULLNAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.NAME_FULLNAME, new SifString( value ), value );
		}
	}

}}