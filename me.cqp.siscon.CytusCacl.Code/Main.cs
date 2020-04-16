using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using Newtonsoft.Json;

namespace me.cqp.siscon.CytusCalc.Code
{
    public class Main : IGroupMessage,IPrivateMessage
    {
        public static string songlistText = @"{
  ""songs"": [
    {
      ""song_title"": ""Amenemhat"",
      ""song_pack"": ""Sagar"",
      ""difficulty"": [ ""5"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Elysium"",
      ""song_pack"": ""Sagar"",
      ""difficulty"": [ ""3"", ""6"", ""12"", ""null"" ]
},
    {
      ""song_title"": ""Immram Brain"",
      ""song_pack"": ""Sagar"",
      ""difficulty"": [ ""3"", ""6"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Space Alien"",
      ""song_pack"": ""Sagar"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Doldrums"",
      ""song_pack"": ""Sagar"",
      ""difficulty"": [ ""4"", ""7"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Nídhögg"",
      ""song_pack"": ""Sagar"",
      ""difficulty"": [ ""5"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Legacy"",
      ""song_pack"": ""Sagar"",
      ""difficulty"": [ ""5"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""A Portent of the Silver Wheel"",
      ""song_pack"": ""Sagar"",
      ""difficulty"": [ ""3"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Sacrifice"",
      ""song_pack"": ""Sagar"",
      ""difficulty"": [ ""3"", ""7"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Return of the Lamp"",
      ""song_pack"": ""Sagar"",
      ""difficulty"": [ ""4"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""The Siege"",
      ""song_pack"": ""Rin"",
      ""difficulty"": [ ""3"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""The Grand Debate"",
      ""song_pack"": ""Rin"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""三灯火"",
      ""song_pack"": ""Rin"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""「妖怪録、我し来にけり。 」"",
      ""song_pack"": ""Rin"",
      ""difficulty"": [ ""4"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Starry Summoner"",
      ""song_pack"": ""Rin"",
      ""difficulty"": [ ""2"", ""5"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""すゝめ☆クノイチの巻"",
      ""song_pack"": ""Rin"",
      ""difficulty"": [ ""5"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""彩"",
      ""song_pack"": ""Rin"",
      ""difficulty"": [ ""4"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""決戦"",
      ""song_pack"": ""Rin"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Mari-Temari"",
      ""song_pack"": ""Rin"",
      ""difficulty"": [ ""2"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Inari"",
      ""song_pack"": ""Rin"",
      ""difficulty"": [ ""3"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Blue Star"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""3"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""BREAK IT"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Can't Make a Song!!"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""4"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Miku"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""3"", ""6"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Sharing The World"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""3"", ""6"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Venus di Ujung Jari"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""1"", ""5"", ""8"", ""null"" ]
    },
    {
      ""song_title"": ""ラッキー☆オーブ"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""4"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""ラッキー☆オーブ (3R2 Remix)"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""4"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""魔法みたいなミュージック！"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""3"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""月西江"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""2"", ""5"", ""8"", ""null"" ]
    },
    {
      ""song_title"": ""Ten Thousand Stars"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""4"", ""6"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Glass Wall"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""2"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Cybernetic"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Decade"",
      ""song_pack"": ""Miku"",
      ""difficulty"": [ ""3"", ""6"", ""9"", ""null"" ]
    },
    {
      ""song_title"": ""The Spark"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Resurrection"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""4"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""One Way Love"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""2"", ""6"", ""9"", ""null"" ]
    },
    {
      ""song_title"": ""Happiness Breeze"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""14"" ]
    },
    {
      ""song_title"": ""Alterna Pt.1 -Cosmogony-"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""2"", ""5"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Zealous Hearts (Rayark Edit)"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Keep it up"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""5"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""CODE NAME: GAMMA"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""5"", ""9"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""Blow my mind"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Chrome VOX"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""4"", ""9"", ""15"", ""15"" ]
    },
    {
      ""song_title"": ""Hard Landing"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""8"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Brain Power"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Sdorica The Story Unfolds"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""2"", ""5"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Hesitant Blade"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""2"", ""5"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""extinguisher"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""FUJIN Rumble"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""5"", ""9"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""For You the Bellz Toll"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""4"", ""7"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Rei"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""気楽なCloudy"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""5"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""響け!"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""4"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Praystation (HiTECH NINJA Remix)"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""100sec Cat Dreams"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""4"", ""7"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""REmorse"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""5"", ""9"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""Stranger"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""2"", ""6"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""小悪魔×3の大脫走！？"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Online"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Sunday Night Blues"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""2"", ""5"", ""9"", ""null"" ]
    },
    {
      ""song_title"": ""Blow My Mind (tpz Overheat Remix)"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""4"", ""7"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""Maboroshi"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""4"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""TOKONOMA Spacewalk"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""UnNOT!CED"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""下水鳴動して鼠一匹"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Capybara Kids' Paradise"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""6"", ""9"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""Walnuts Walkers"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Hydra"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""5"", ""8"", ""12"", ""15"" ]
    },
    {
      ""song_title"": ""Liberation"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""6"", ""9"", ""14"", ""15"" ]
    },
    {
      ""song_title"": ""Ramen is God"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""6"", ""9"", ""14"", ""15"" ]
    },
    {
      ""song_title"": ""Re:VeLΔTiØN ～光道ト破坏ノ双白翼～"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""5"", ""9"", ""14"", ""15"" ]
    },
    {
      ""song_title"": ""Rebirth"",
      ""song_pack"": ""NEKO#ΦωΦ"",
      ""difficulty"": [ ""3"", ""7"", ""13"", ""15"" ]
    },
    {
      ""song_title"": ""change"",
      ""song_pack"": ""Aroma"",
      ""difficulty"": [ ""1"", ""5"", ""9"", ""null"" ]
    },
    {
      ""song_title"": ""No One Can't Stop Me"",
      ""song_pack"": ""Aroma"",
      ""difficulty"": [ ""3"", ""5"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Spotlight On"",
      ""song_pack"": ""Aroma"",
      ""difficulty"": [ ""3"", ""6"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Bring the light"",
      ""song_pack"": ""Aroma"",
      ""difficulty"": [ ""2"", ""5"", ""8"", ""null"" ]
    },
    {
      ""song_title"": ""Make U Mine"",
      ""song_pack"": ""Aroma"",
      ""difficulty"": [ ""3"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Anzen Na Kusuri"",
      ""song_pack"": ""Aroma"",
      ""difficulty"": [ ""2"", ""6"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""漂流"",
      ""song_pack"": ""Aroma"",
      ""difficulty"": [ ""4"", ""7"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Perspectives"",
      ""song_pack"": ""Aroma"",
      ""difficulty"": [ ""2"", ""5"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""風の声"",
      ""song_pack"": ""Aroma"",
      ""difficulty"": [ ""2"", ""4"", ""9"", ""null"" ]
    },
    {
      ""song_title"": ""Beautiful Lie"",
      ""song_pack"": ""Aroma"",
      ""difficulty"": [ ""3"", ""6"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Neon Escape"",
      ""song_pack"": ""Aroma"",
      ""difficulty"": [ ""2"", ""6"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Uranus"",
      ""song_pack"": ""Nora"",
      ""difficulty"": [ ""3"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Drop The World"",
      ""song_pack"": ""Nora"",
      ""difficulty"": [ ""4"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Starlight (KIVΛ Remix)"",
      ""song_pack"": ""Nora"",
      ""difficulty"": [ ""2"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Bastard of Hardcore"",
      ""song_pack"": ""Nora"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Jakarta PROGRESSION"",
      ""song_pack"": ""Nora"",
      ""difficulty"": [ ""3"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Eternity"",
      ""song_pack"": ""Nora"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Phagy Mutation"",
      ""song_pack"": ""Nora"",
      ""difficulty"": [ ""2"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""ATONEMENT"",
      ""song_pack"": ""Nora"",
      ""difficulty"": [ ""3"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Grand Emotion"",
      ""song_pack"": ""Nora"",
      ""difficulty"": [ ""2"", ""6"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Scenery in your eyes"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""2"", ""6"", ""9"", ""null"" ]
    },
    {
      ""song_title"": ""LEVEL4"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Living for you (Andy Tunstall remix)"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""I'M NOT"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""2"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Stop at nothing (Andy Tunstall remix)"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""2"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""RETRIEVE"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Still"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""2"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""CREDENCE"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""3"", ""8"", ""12"", ""13"" ]
    },
    {
      ""song_title"": ""SYSTEMFEIT"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""3"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""hunted"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""2"", ""6"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Capture me"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""2"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Realize"",
      ""song_pack"": ""Cherry"",
      ""difficulty"": [ ""3"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Body Talk"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""1"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Survive"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""1"", ""5"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Bullet Waiting for Me (James Landino remix)"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""1"", ""4"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""KANATA"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""2"", ""6"", ""9"", ""12"" ]
    },
    {
      ""song_title"": ""Fight Another Day (Andy Tunstall remix)"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""2"", ""6"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Baptism of Fire (CliqTrack remix)"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Fireflies (Funk Fiction remix)"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""3"", ""6"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Gravity"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""13"" ]
    },
    {
      ""song_title"": ""Re:Boost"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""2"", ""5"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Green Hope"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Under the same sky"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""1"", ""7"", ""9"", ""null"" ]
    },
    {
      ""song_title"": ""So In Love"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""1"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Winter Games"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""2"", ""5"", ""9"", ""null"" ]
    },
    {
      ""song_title"": ""New World"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""3"", ""6"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""SECRET;WEAPON"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""5"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Lilac for Anabel"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Who Am I?"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""2"", ""6"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""More Than Diamond"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""2"", ""5"", ""9"", ""null"" ]
    },
    {
      ""song_title"": ""Blossoms for Life"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Cityscape"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""2"", ""6"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Favorites"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""2"", ""5"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Make Me Alive"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""3"", ""5"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Light up my love!!"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""3"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Super attractor"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""5"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Recall"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""3"", ""6"", ""9"", ""null"" ]
    },
    {
      ""song_title"": ""Sleeping Beast"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""4"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""I Wish You Were Mine"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""PIXIE DUST"",
      ""song_pack"": ""PAFF"",
      ""difficulty"": [ ""1"", ""5"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Chocolate Missile"",
      ""song_pack"": ""NEKO"",
      ""difficulty"": [ ""2"", ""6"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""I can avoid it.#φωφ"",
      ""song_pack"": ""NEKO"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""一啖兩啖"",
      ""song_pack"": ""NEKO"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Mammal"",
      ""song_pack"": ""NEKO"",
      ""difficulty"": [ ""4"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Blah!!"",
      ""song_pack"": ""NEKO"",
      ""difficulty"": [ ""4"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""リラ"",
      ""song_pack"": ""NEKO"",
      ""difficulty"": [ ""4"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Log In"",
      ""song_pack"": ""NEKO"",
      ""difficulty"": [ ""3"", ""6"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""DJ Mashiro is dead or alive"",
      ""song_pack"": ""NEKO"",
      ""difficulty"": [ ""5"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Re:incRnaTiØN ～夕焼ケ世界ノ決別ヲ～"",
      ""song_pack"": ""NEKO"",
      ""difficulty"": [ ""6"", ""9"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""R.I.P."",
      ""song_pack"": ""NEKO"",
      ""difficulty"": [ ""5"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Deadly Slot Game"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""13"" ]
    },
    {
      ""song_title"": ""Make Me Burn"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""6"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Restriction"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""4"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Luolimasi"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""2"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Claim the Game"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Devilic Sphere"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""9"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Pure Powerstomper"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Celestial Sounds (KIVΛ Remix)"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Grimoire of Crimson"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""4"", ""8"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Dasein"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""4"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""CHAOS"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""5"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""EMber"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Midnight"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Dead Point"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Nocturnal Type"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""4"", ""8"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Sickest City"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""7"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Jazzy Glitch Machine"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""dimensionalize nervous breakdown (rev.flat)"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""cold"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""4"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""NRG_Tech"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Break Through The Barrier"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""4"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Dead Master"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""9"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Accelerator"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""2"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Armaros"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Break The Core"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""4"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Milky Way Galaxy (SIHanatsuka Remix)"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""ViRUS"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Awakening"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""2"", ""5"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Hagiasmos"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""5"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Fade Into The Darkness"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""5"", ""9"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""SHIRO"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""2"", ""6"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Tunnef's Nightmare"",
      ""song_pack"": ""ROBO_Head"",
      ""difficulty"": [ ""3"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Cristalisia"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""6"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Occidens"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""7"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Red Five"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""iL"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""5"", ""10"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""CODENAME : SIGMA"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""5"", ""9"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""New Challenger Approaching"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""5"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""What's Your PR.Ice?"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""VIS::CRACKED"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""5"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""CODENAME : SIGMA"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""5"", ""9"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""DigiGroove"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Heat Ring"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Leaving All Behind"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Symmetry"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""9"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""Time to Fight"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""5"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Bloody Purity"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""5"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Masquerade"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Quantum Labyrinth"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Saika"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""To Further Dream"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Libera Me"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Qualia"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""9"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Reset"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""D R G"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""2"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Sentimental Journey"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""7"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Biotonic"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Alexandrite"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Tokiwatari"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Purge"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Area184"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""BloodyMare"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""AssaultMare"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Lunar Mare"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""99 Glooms"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""5"", ""7"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Pressure"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""V."",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""6"", ""10"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""Halloween Party"",
      ""song_pack"": ""Ivy"",
      ""difficulty"": [ ""4"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Xiorc"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""4"", ""10"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""REBELLIUM"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""3"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Imprinting"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""15"" ]
    },
    {
      ""song_title"": ""Gekkouka"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""4"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Light of Buenos Aires"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""tondari-hanetari"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""3"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Abduction"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""4"", ""8"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Nostalgia Sonatina"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""I luv U"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Instinct"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""4"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Floor of Lava"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""6"", ""10"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""Aphasia"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""2"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Olympia"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""3"", ""6"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Demetrius"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""2"", ""6"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""L'Ultima Cena"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""4"", ""8"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Deus Ex Machina"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Fur War, Pur War"",
      ""song_pack"": ""ConneR"",
      ""difficulty"": [ ""4"", ""8"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""INSPION"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""4"", ""9"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Whisper in my Head"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""2"", ""7"", ""13"", ""null"" ]
    },

    {
      ""song_title"": ""Return"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""3"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""concentric circles"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""4"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Fighting"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""2"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""To the Light"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""4"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Phantom Razor"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""14"" ]
    },
    {
      ""song_title"": ""Black Hole"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""2"", ""4"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Samurai"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""4"", ""9"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""IOLITE-SUNSTONE"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Sairai"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""2"", ""5"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""Ultimate feat. 放課後のあいつ"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""3"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Karma"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Chosen"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Violet"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""2"", ""7"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Asylum"",
      ""song_pack"": ""Xenon"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Childish"",
      ""song_pack"": ""JOE"",
      ""difficulty"": [ ""4"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Turnstile Jumper"",
      ""song_pack"": ""JOE"",
      ""difficulty"": [ ""4"", ""7"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Juicy Gossip"",
      ""song_pack"": ""JOE"",
      ""difficulty"": [ ""3"", ""7"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Standby for Action"",
      ""song_pack"": ""JOE"",
      ""difficulty"": [ ""4"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Open the Game"",
      ""song_pack"": ""JOE"",
      ""difficulty"": [ ""4"", ""6"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Hydrangea"",
      ""song_pack"": ""JOE"",
      ""difficulty"": [ ""3"", ""6"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Absolutely"",
      ""song_pack"": ""JOE"",
      ""difficulty"": [ ""2"", ""5"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Higher and Higher\t"",
      ""song_pack"": ""JOE"",
      ""difficulty"": [ ""3"", ""6"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Take me to the Future"",
      ""song_pack"": ""JOE"",
      ""difficulty"": [ ""3"", ""7"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Nautilus"",
      ""song_pack"": ""JOE"",
      ""difficulty"": [ ""2"", ""5"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Bass Music"",
      ""song_pack"": ""JOE"",
      ""difficulty"": [ ""2"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Anchor"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""1"", ""5"", ""10"", ""null"" ]
    },
    {
      ""song_title"": ""syūten"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""2"", ""5"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""Rosa Rubus"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""2"", ""6"", ""11"", ""null"" ]
    },
    {
      ""song_title"": ""XYZ"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""5"", ""9"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""II-V"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""3"", ""7"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Chaos and Abyss -3rd Movement-"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""6"", ""10"", ""15"", ""null"" ]
    },
    {
      ""song_title"": ""Duality"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""3"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""Ra"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""3"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""CHAOS //System Offline// 	"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""4"", ""8"", ""12"", ""null"" ]
    },
    {
      ""song_title"": ""V. //System Offline//"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""4"", ""8"", ""13"", ""null"" ]
    },
    {
      ""song_title"": ""Ⅱ"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""5"", ""9"", ""14"", ""null"" ]
    },
    {
      ""song_title"": ""Used to be"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""2"", ""5"", ""9"", ""null"" ]
    },
    {
      ""song_title"": ""The Whole Rest"",
      ""song_pack"": ""Vanessa"",
      ""difficulty"": [ ""4"", ""7"", ""12"", ""null"" ]
    }
  ]
}";

        public static CytusIISongsRootObject songlist = JsonConvert.DeserializeObject<CytusIISongsRootObject>(songlistText);

        public void GroupMessage(object sender, CQGroupMessageEventArgs e)
        {
            string[] message = e.Message.Text.Split(' ');
            if ((message[0] == "/cy" || message[0] == "cytus")&&message.Length!=1)
            {
                if (message.Length ==7&&message[1]=="calc")
                {
                    Task<string> task = ScoreCalc(message[2], message[3], message[4], message[5], message[6]);
                    e.FromGroup.SendGroupMessage($"[CQ:at,qq={e.FromQQ.Id}]\n" + task.Result);
                    e.Handler = true;
                }
                else if(message.Length==4&&message[1]=="least")
                {
                    Task<string> task = LeastScoreCalc(message[2], message[3]);
                    e.FromGroup.SendGroupMessage($"[CQ:at,qq={e.FromQQ.Id}]\n"+task.Result);
                    e.Handler = true;
                }
                else if (message[1] == "rand" && message.Length == 2)//判断是否符合least命令
                {
                    Task<string> task = RandomSong();
                    e.FromGroup.SendGroupMessage($"[CQ:at,qq={e.FromQQ.Id}]\n"+task.Result);
                    e.Handler = true;
                }
                else if (message[1] == "rand" && message.Length == 3)//判断是否符合least命令
                {
                    Task<string> task = RandomSongLimitSelect(message[2]);
                    e.FromGroup.SendGroupMessage($"[CQ:at,qq={e.FromQQ.Id}]\n"+task.Result);
                    e.Handler = true;
                }
                else if (message.Length == 2 && message[1] == "help")
                {
                    e.FromGroup.SendGroupMessage("查询cytus指令格式如下\n1./cytus <calc>(或/cy <calc>) [perfect] [good] [bad] [miss] [tp]来查询彩P黑P\n2./cytus (或/cy)<least> [perfect] [tp]来查询在Million Master情况下达到预期TP最少需要的黑P数\n3./cytus (或/cy) <rand> [难度参数（可选）]来进行随机选取Cytus歌曲（eg./cy rand chaos 或/cy rand 13）");
                    e.Handler = true;
                }
                else
                {
                    e.FromGroup.SendGroupMessage($"[CQ:at,qq={e.FromQQ.Id}]\n 参数好像不对呢~请检查参数是否合法哦~");
                }
            }
            else
            {
                e.Handler = false;
            }
        }

        public static async Task<string> ScoreCalc(string perfectNoteS, string goodNoteS, string badNoteS, string missNoteS, string playerTpS) //计算彩P黑P
        {
            return await Task.Run(() =>
            {
                string info;

                int judge;

                double perfectNote;
                double goodNote;
                double badNote;
                double missNote;
                double playerTp;

                double colourPerfect = 0;
                double blackPerfect = 0;
                double noteNumber = 0;
                double realTp = 0;

                if (int.TryParse(perfectNoteS, out judge) && int.TryParse(goodNoteS, out judge) && int.TryParse(badNoteS, out judge) && int.TryParse(missNoteS, out judge) && double.TryParse(playerTpS, out playerTp))
                {
                    perfectNote = Convert.ToDouble(perfectNoteS);
                    goodNote = Convert.ToDouble(goodNoteS);
                    badNote = Convert.ToDouble(badNoteS);
                    missNote = Convert.ToDouble(missNoteS);
                    playerTp = Convert.ToDouble(playerTpS);

                    noteNumber = perfectNote + goodNote + badNote + missNote;
                    //return Convert.ToString( noteNumber);

                    blackPerfect = Math.Round((((perfectNote) * 100 / noteNumber) - (playerTp - ((goodNote * 30) / noteNumber))) / (30 / noteNumber), 0);

                    colourPerfect = perfectNote - blackPerfect;

                    realTp = colourPerfect * 100 / noteNumber + blackPerfect * 70 / noteNumber + goodNote * 30 / noteNumber;

                    info = "您的ColourPerfect是: " + Convert.ToString(colourPerfect) + "\n" + "您的BlackPerfect是: " + Convert.ToString(blackPerfect) + "\n" + "您的真实Tp为: " + Convert.ToString(realTp) + "%";

                    return info;
                }
                else
                {
                    return "欸欸欸？？我不能计算成功欸~参数是错了吗？";
                }
            }).ConfigureAwait(false);
        }

        public static async Task<string> LeastScoreCalc(string noteNumberS, string playerTpS)
        {
            return await Task.Run(() =>
            {
                int judge;

                double noteNumber;
                double playerTp;
                double leastBlackPerfect;

                if (int.TryParse(noteNumberS, out judge) && double.TryParse(playerTpS, out playerTp))
                {
                    noteNumber = Convert.ToDouble(noteNumberS);
                    playerTp = Convert.ToDouble(playerTpS);
                    leastBlackPerfect = noteNumber * (100 - playerTp) / 30;
                    if ((playerTp <= 100 && playerTp >= 0) && noteNumber > 0)
                    {
                        return "在Million Master的情况下，您需要至少：" + Convert.ToString(Math.Round(leastBlackPerfect)) + "个BlackPerfect来达到TP：" + playerTpS;
                    }
                    else
                    {
                        return "要么您是神，可以达到这样的程度，要么您的参数就是乱输的哦~";
                    }

                }
                else
                {
                    return "欸欸欸？？我不能转换成功欸~参数是错了吗？";
                }
            }).ConfigureAwait(false);
        }

        public void PrivateMessage(object sender, CQPrivateMessageEventArgs e)
        {
            string[] message = e.Message.Text.Split(' ');
            if ((message[0] == "/cy" || message[0] == "/cytus") && message.Length != 1)
            {
                if (message.Length == 7 && message[1] == "calc")
                {
                    Task<string> task = ScoreCalc(message[2], message[3], message[4], message[5], message[6]);
                    e.FromQQ.SendPrivateMessage(task.Result);
                    e.Handler = true;
                }
                else if (message.Length == 4 && message[1] == "least")
                {
                    Task<string> task = LeastScoreCalc(message[2], message[3]);
                    e.FromQQ.SendPrivateMessage(task.Result);
                    e.Handler = true;
                }
                else if(message.Length==2&&message[1]=="help")
                {
                    e.FromQQ.SendPrivateMessage("查询cytus指令格式如下\n1./cytus <calc>(或/cy <calc>) [perfect] [good] [bad] [miss] [tp]来查询彩P黑P\n2./cytus (或/cy)<least> [perfect] [tp]来查询在Million Master情况下达到预期TP最少需要的黑P数\n3./cytus (或/cy) <rand> [难度参数（可选）]来进行随机选取Cytus歌曲（eg./cy rand chaos 或/cy rand 13）");
                    e.Handler = true;
                }
                else if (message[1] == "rand" && message.Length == 2)//判断是否符合least命令
                {
                    Task<string> task = RandomSong();
                    e.FromQQ.SendPrivateMessage(task.Result);
                    e.Handler = true;
                }
                else if (message[1] == "rand" && message.Length == 3)//判断是否符合least命令
                {
                    Task<string> task = RandomSongLimitSelect(message[2]);
                    e.FromQQ.SendPrivateMessage(task.Result);
                    e.Handler = true;
                }
                else
                {
                    e.FromQQ.SendPrivateMessage("参数好像不对呢~请检查参数是否合法哦~");
                }
            }
            else
            {
                e.Handler = false;
            }
        }

        public static async Task<string> RandomSong()
        {
            return await Task.Run(() =>
            {
                Random rangdomSong = new Random();
                Random rangdomDifficulty = new Random();
                int randomDifficultyId = rangdomDifficulty.Next(0, 4);
                int randomSongId = rangdomSong.Next(0, songlist.songs.Count);
                if (randomDifficultyId == 0)
                {
                    return "您抽到了歌曲是：" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")" + "\n(Easy " + songlist.songs[randomSongId].difficulty[0] + ")";
                }
                else if (randomDifficultyId == 1)
                {
                    return "您抽到了歌曲是：" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")" + "\n(Hard " + songlist.songs[randomSongId].difficulty[1] + ")";
                }
                else if (randomDifficultyId == 2)
                {
                    return "您抽到了歌曲是：" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")" + "\n(Chaos " + songlist.songs[randomSongId].difficulty[2] + ")";
                }
                else
                {
                    if (songlist.songs[randomSongId].difficulty[randomDifficultyId] == "null")
                    {
                        return "您抽到了歌曲是：" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")" + "\n(Chaos " + songlist.songs[randomSongId].difficulty[2] + ")";
                    }
                    else
                    {
                        return "您抽到了歌曲是：" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")" + "\n(Glitch " + songlist.songs[randomSongId].difficulty[3] + ")";
                    }
                }
            }).ConfigureAwait(false);
        }

        public static async Task<string> RandomSongLimitSelect(string limitDifficulty)
        {
            return await Task.Run(() =>
            {
                Random rangdomSong = new Random();
                int judgeInfinity = 0;
                if (limitDifficulty.ToLower() == "easy")
                {
                    int randomSongId = rangdomSong.Next(0, songlist.songs.Count);
                    return "您抽到的歌曲是：\n" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")\n" + " " + "Easy" + " " + songlist.songs[randomSongId].difficulty[0];
                }
                else if (limitDifficulty.ToLower() == "hard")
                {
                    int randomSongId = rangdomSong.Next(0, songlist.songs.Count);
                    return "您抽到的歌曲是：\n" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")\n" + " " + "Hard" + " " + songlist.songs[randomSongId].difficulty[1];
                }
                else if (limitDifficulty.ToLower() == "chaos")
                {
                    int randomSongId = rangdomSong.Next(0, songlist.songs.Count);
                    return "您抽到的歌曲是：\n" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")\n" + " " + "Chaos" + " " + songlist.songs[randomSongId].difficulty[2];
                }
                else if (limitDifficulty.ToLower() == "glitch")
                {
                    int randomSongId = rangdomSong.Next(0, songlist.songs.Count);
                    while (songlist.songs[randomSongId].difficulty[3] == "null")
                    {
                        randomSongId = rangdomSong.Next(0, songlist.songs.Count);
                    }
                    return "您抽到的歌曲是：\n" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")\n" + " " + "Glitch" + " " + songlist.songs[randomSongId].difficulty[3];
                }
                else
                {
                    while (true)
                    {
                        judgeInfinity++;

                        int randomSongId = rangdomSong.Next(0, songlist.songs.Count);

                        if (songlist.songs[randomSongId].difficulty[0] == limitDifficulty)
                        {
                            return "您抽到的歌曲是：\n" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")\n" + " " + "Easy" + " " + limitDifficulty;
                        }
                        else if (songlist.songs[randomSongId].difficulty[1] == limitDifficulty)
                        {
                            return "您抽到的歌曲是：\n" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")\n" + " " + "Hard" + " " + limitDifficulty;
                        }
                        else if (songlist.songs[randomSongId].difficulty[2] == limitDifficulty)
                        {
                            return "您抽到的歌曲是：\n" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")\n" + " " + "Chaos" + " " + limitDifficulty;
                        }
                        else if (songlist.songs[randomSongId].difficulty[3] == limitDifficulty)
                        {
                            return "您抽到的歌曲是：\n" + songlist.songs[randomSongId].song_title + "(" + songlist.songs[randomSongId].song_pack + ")\n" + " " + "Glitch" + " " + limitDifficulty;
                        }

                        if (judgeInfinity >= 3000)//判断是否进入死循环且阈值为3000次
                        {
                            return "参数好像错了哦~";
                        }
                    }
                }
            }).ConfigureAwait(false);
        }
    }

    public class CytusIISongs
    {
        public string song_title { get; set; }
        public string song_pack { get; set; }
        public List<string> difficulty { get; set; }
    }

    public class CytusIISongsRootObject
    {
        public List<CytusIISongs> songs { get; set; }
    }
}
