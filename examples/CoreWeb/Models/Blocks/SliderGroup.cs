/*
 * Copyright (c) 2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/tidyui/coreweb
 * 
 */

using Piranha.Extend;
using Piranha.Extend.Blocks;
using Piranha.Extend.Fields;

namespace CoreWeb.Models.Blocks
{
    /// <summary>
    /// Simple region for some optional page heading information.
    /// </summary>
    [BlockGroupType(Name = "Slider", Category = "Groups", Icon = "far fa-newspaper", UseCustomView = true)]
    [BlockItemType(Type = typeof(HtmlBlock))]
    [BlockItemType(Type = typeof(HtmlColumnBlock))]

    public class SliderGroup : BlockGroup
    {
        public StringField MainTitle { get; set; }
    }
}
