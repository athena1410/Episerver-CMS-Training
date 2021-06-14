﻿using EPiServer.DataAnnotations;
using EPiServer.Security;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining
{
    [GroupDefinitions]
    public class SiteTabNames
    {
        [Display(Order = 10)]
        [RequiredAccess(AccessLevel.Edit)]
        public const string SEO = "SEO";

        [Display(Order = 20)]
        [RequiredAccess(AccessLevel.Administer)]
        public const string SITE_SETTINGS = "SiteSettings";
    }
}