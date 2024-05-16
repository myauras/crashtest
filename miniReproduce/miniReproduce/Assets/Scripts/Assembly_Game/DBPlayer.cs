using System;
using System.Collections.Generic;
using Realms;

[MapTo("player")]
public partial class DBPlayer : IRealmObject {
    [MapTo("_id")]
    [PrimaryKey]
    [Required]
    public string ID { get; private set; }
    [MapTo("createdAt")]
    public DateTimeOffset CreatedAt { get; private set; }
    [MapTo("authType")]
    public string AuthType { get; private set; }
    [MapTo("ban")]
    public bool? Ban { get; private set; }
    [MapTo("deviceUID")]
    public string DeviceUID { get; private set; }
    [MapTo("lastSigninAt")]
    public DateTimeOffset? LastSigninAt { get; private set; }
    [MapTo("lastSignoutAt")]
    public DateTimeOffset? LastSignoutAt { get; private set; }
    [MapTo("onlineState")]
    public string OnlineState { get; private set; }
    [MapTo("point")]
    public long? Point { get; private set; }
    [MapTo("heroExp")]
    public int? HeroExp { get; private set; }
    [MapTo("spellLVs")]
    public IList<int> SpellLVs { get; }
    [MapTo("spellCharges")]
    public IList<double> SpellCharges { get; }
    [MapTo("drops")]
    public IList<int> Drops { get; }
    
    [MapTo("inMatchgameID")]
    public string InMatchgameID { get; private set; }
    [MapTo("leftGameAt")]
    public DateTimeOffset? LeftGameAt { get; private set; }

}