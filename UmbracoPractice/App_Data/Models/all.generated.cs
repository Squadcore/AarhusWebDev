using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "e1b3fdf1c329a326")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.8.100
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("homePage")]
	public partial class HomePage : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta Descritpion
		///</summary>
		[ImplementPropertyType("metaDescritpion")]
		public string MetaDescritpion
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaDescritpion(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetUmbracoNaviHide(this); }
		}
	}

	// Mixin content Type 1067 with alias "master"
	/// <summary>Master</summary>
	public partial interface IMaster : IPublishedContent
	{
		/// <summary>Meta Descritpion</summary>
		string MetaDescritpion { get; }

		/// <summary>MetaKeywords</summary>
		string MetaKeywords { get; }

		/// <summary>umbracoNaviHide</summary>
		bool UmbracoNaviHide { get; }
	}

	/// <summary>Master</summary>
	[PublishedContentModel("master")]
	public partial class Master : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "master";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Master(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Master, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta Descritpion
		///</summary>
		[ImplementPropertyType("metaDescritpion")]
		public string MetaDescritpion
		{
			get { return GetMetaDescritpion(this); }
		}

		/// <summary>Static getter for Meta Descritpion</summary>
		public static string GetMetaDescritpion(IMaster that) { return that.GetPropertyValue<string>("metaDescritpion"); }

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return GetMetaKeywords(this); }
		}

		/// <summary>Static getter for MetaKeywords</summary>
		public static string GetMetaKeywords(IMaster that) { return that.GetPropertyValue<string>("metaKeywords"); }

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return GetUmbracoNaviHide(this); }
		}

		/// <summary>Static getter for umbracoNaviHide</summary>
		public static bool GetUmbracoNaviHide(IMaster that) { return that.GetPropertyValue<bool>("umbracoNaviHide"); }
	}

	/// <summary>Text Page</summary>
	[PublishedContentModel("textPage")]
	public partial class TextPage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "textPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TextPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TextPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("header")]
		public string Header
		{
			get { return this.GetPropertyValue<string>("header"); }
		}

		///<summary>
		/// MainContent
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return this.GetPropertyValue<IHtmlString>("mainContent"); }
		}
	}

	/// <summary>Overview</summary>
	[PublishedContentModel("overview")]
	public partial class Overview : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "overview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Overview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Overview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// ArticlesBodyText
		///</summary>
		[ImplementPropertyType("articlesBodyText")]
		public IHtmlString ArticlesBodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("articlesBodyText"); }
		}

		///<summary>
		/// ArticlesTitle
		///</summary>
		[ImplementPropertyType("articlesTitle")]
		public string ArticlesTitle
		{
			get { return this.GetPropertyValue<string>("articlesTitle"); }
		}
	}

	/// <summary>ArticleItem</summary>
	[PublishedContentModel("articleItem")]
	public partial class ArticleItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "articleItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticleItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticleItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// ArticleTextArea
		///</summary>
		[ImplementPropertyType("articleTextArea")]
		public IHtmlString ArticleTextArea
		{
			get { return this.GetPropertyValue<IHtmlString>("articleTextArea"); }
		}

		///<summary>
		/// ArticleTitle
		///</summary>
		[ImplementPropertyType("articleTitle")]
		public string ArticleTitle
		{
			get { return this.GetPropertyValue<string>("articleTitle"); }
		}
	}

	/// <summary>Projects Overview</summary>
	[PublishedContentModel("projectsOverview")]
	public partial class ProjectsOverview : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "projectsOverview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProjectsOverview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjectsOverview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Projects Body Text
		///</summary>
		[ImplementPropertyType("projectsBodyText")]
		public IHtmlString ProjectsBodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("projectsBodyText"); }
		}

		///<summary>
		/// Projects Title
		///</summary>
		[ImplementPropertyType("projectsTitle")]
		public string ProjectsTitle
		{
			get { return this.GetPropertyValue<string>("projectsTitle"); }
		}

		///<summary>
		/// Meta Descritpion
		///</summary>
		[ImplementPropertyType("metaDescritpion")]
		public string MetaDescritpion
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaDescritpion(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>ProjectItem</summary>
	[PublishedContentModel("projectItem")]
	public partial class ProjectItem : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "projectItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProjectItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjectItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Project Description
		///</summary>
		[ImplementPropertyType("projectDescription")]
		public IHtmlString ProjectDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("projectDescription"); }
		}

		///<summary>
		/// Project Status
		///</summary>
		[ImplementPropertyType("projectStatus")]
		public int ProjectStatus
		{
			get { return this.GetPropertyValue<int>("projectStatus"); }
		}

		///<summary>
		/// ProjectTitle
		///</summary>
		[ImplementPropertyType("projectTitle")]
		public string ProjectTitle
		{
			get { return this.GetPropertyValue<string>("projectTitle"); }
		}

		///<summary>
		/// Meta Descritpion
		///</summary>
		[ImplementPropertyType("metaDescritpion")]
		public string MetaDescritpion
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaDescritpion(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Contacts Page</summary>
	[PublishedContentModel("contactsPage")]
	public partial class ContactsPage : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactsPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactsPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactsPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta Descritpion
		///</summary>
		[ImplementPropertyType("metaDescritpion")]
		public string MetaDescritpion
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaDescritpion(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Articles Overview</summary>
	[PublishedContentModel("articlesOverview")]
	public partial class ArticlesOverview : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "articlesOverview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticlesOverview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticlesOverview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Articles body text
		///</summary>
		[ImplementPropertyType("articlesBodyText")]
		public IHtmlString ArticlesBodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("articlesBodyText"); }
		}

		///<summary>
		/// Articles Title: The title of your project
		///</summary>
		[ImplementPropertyType("articlesTitle")]
		public string ArticlesTitle
		{
			get { return this.GetPropertyValue<string>("articlesTitle"); }
		}
	}

	/// <summary>About us</summary>
	[PublishedContentModel("aboutUs")]
	public partial class AboutUs : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "aboutUs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AboutUs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AboutUs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// About Us Content
		///</summary>
		[ImplementPropertyType("aboutUsContent")]
		public Newtonsoft.Json.Linq.JToken AboutUsContent
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("aboutUsContent"); }
		}

		///<summary>
		/// Meta Descritpion
		///</summary>
		[ImplementPropertyType("metaDescritpion")]
		public string MetaDescritpion
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaDescritpion(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Message</summary>
	[PublishedContentModel("message")]
	public partial class Message : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "message";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Message(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Message, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Email
		///</summary>
		[ImplementPropertyType("email")]
		public string Email
		{
			get { return this.GetPropertyValue<string>("email"); }
		}

		///<summary>
		/// MessageContent
		///</summary>
		[ImplementPropertyType("messageContent")]
		public string MessageContent
		{
			get { return this.GetPropertyValue<string>("messageContent"); }
		}

		///<summary>
		/// Messagename
		///</summary>
		[ImplementPropertyType("messagename")]
		public string Messagename
		{
			get { return this.GetPropertyValue<string>("messagename"); }
		}

		///<summary>
		/// Subject
		///</summary>
		[ImplementPropertyType("subject")]
		public string Subject
		{
			get { return this.GetPropertyValue<string>("subject"); }
		}

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Login</summary>
	[PublishedContentModel("login")]
	public partial class Login : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "login";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Login(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Login, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta Descritpion
		///</summary>
		[ImplementPropertyType("metaDescritpion")]
		public string MetaDescritpion
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaDescritpion(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Members</summary>
	[PublishedContentModel("members")]
	public partial class Members : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "members";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Members(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Members, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta Descritpion
		///</summary>
		[ImplementPropertyType("metaDescritpion")]
		public string MetaDescritpion
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaDescritpion(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Forbidden Access</summary>
	[PublishedContentModel("forbiddenAccess")]
	public partial class ForbiddenAccess : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "forbiddenAccess";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ForbiddenAccess(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ForbiddenAccess, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta Descritpion
		///</summary>
		[ImplementPropertyType("metaDescritpion")]
		public string MetaDescritpion
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaDescritpion(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

	/// <summary>Active</summary>
	[PublishedContentModel("active")]
	public partial class Active : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "active";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Active(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Active, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Adress
		///</summary>
		[ImplementPropertyType("adress")]
		public string Adress
		{
			get { return this.GetPropertyValue<string>("adress"); }
		}

		///<summary>
		/// City
		///</summary>
		[ImplementPropertyType("city")]
		public string City
		{
			get { return this.GetPropertyValue<string>("city"); }
		}

		///<summary>
		/// Mobile
		///</summary>
		[ImplementPropertyType("mobile")]
		public string Mobile
		{
			get { return this.GetPropertyValue<string>("mobile"); }
		}

		///<summary>
		/// Photo
		///</summary>
		[ImplementPropertyType("photo")]
		public Umbraco.Web.Models.ImageCropDataSet Photo
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("photo"); }
		}

		///<summary>
		/// Skills
		///</summary>
		[ImplementPropertyType("skills")]
		public IEnumerable<string> Skills
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("skills"); }
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}

		///<summary>
		/// Zip
		///</summary>
		[ImplementPropertyType("zip")]
		public string Zip
		{
			get { return this.GetPropertyValue<string>("zip"); }
		}
	}

	/// <summary>Guest</summary>
	[PublishedContentModel("guest")]
	public partial class Guest : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "guest";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Guest(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Guest, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Mobile
		///</summary>
		[ImplementPropertyType("mobile")]
		public string Mobile
		{
			get { return this.GetPropertyValue<string>("mobile"); }
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
