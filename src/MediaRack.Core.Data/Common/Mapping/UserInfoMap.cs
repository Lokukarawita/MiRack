﻿using FluentNHibernate.Mapping;
using MediaRack.Core.Data.Common.Metadata;
using NHibernate.JsonColumn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaRack.Core.Data.Common.Mapping
{
    public class UserInfoMap : ClassMap<LocalUserInfo>
    {
        public UserInfoMap()
        {
            Table("UserInfo");
            Id(x => x.Username);
            Map(x => x.Password);
            Map(x => x.Settings).CustomType<JsonMappableType<UserSettingsMetaInfo>>();
        }
    }
}
