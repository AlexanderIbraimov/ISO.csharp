﻿using ISO3166Lib.Model;
using System.Collections.Generic;

namespace ISO3166Lib.ISO
{
    internal class ISO639
    {
        internal readonly static IList<IISOModel> Languages;
        static ISO639()
        {
            Languages = new List<IISOModel>
            {
                new Language(alpha2: "aa", alpha3: "aar", family: "Afro-Asiatic", name: "Afar", nativeName: "Afaraf"),
                new Language(alpha2: "ab", alpha3: "abk", family: "Northwest Caucasian", name: "Abkhaz", nativeName: "аҧсуа бызшәа, аҧсшәа"),
                new Language(alpha2: "ae", alpha3: "ave", family: "Indo-European", name: "Avestan", nativeName: "avesta"),
                new Language(alpha2: "af", alpha3: "afr", family: "Indo-European", name: "Afrikaans", nativeName: "Afrikaans"),
                new Language(alpha2: "ak", alpha3: "aka", family: "Niger–Congo", name: "Akan", nativeName: "Akan"),
                new Language(alpha2: "am", alpha3: "amh", family: "Afro-Asiatic", name: "Amharic", nativeName: "አማርኛ"),
                new Language(alpha2: "an", alpha3: "arg", family: "Indo-European", name: "Aragonese", nativeName: "aragonés"),
                new Language(alpha2: "av", alpha3: "ava", family: "Northeast Caucasian", name: "Avaric", nativeName: "авар мацӀ, магӀарул мацӀ"),
                new Language(alpha2: "as", alpha3: "asm", family: "Indo-European", name: "Assamese", nativeName: "অসমীয়া"),
                new Language(alpha2: "ar", alpha3: "ara", family: "Afro-Asiatic", name: "Arabic", nativeName: "العربية"),
                new Language(alpha2: "az", alpha3: "aze", family: "Turkic", name: "Azerbaijani", nativeName: "azərbaycan dili"),
                new Language(alpha2: "ay", alpha3: "aym", family: "Aymaran", name: "Aymara", nativeName: "aymar aru"),
                new Language(alpha2: "ba", alpha3: "bak", family: "Turkic", name: "Bashkir", nativeName: "башҡорт теле"),
                new Language(alpha2: "be", alpha3: "bel", family: "Indo-European", name: "Belarusian", nativeName: "беларуская мова"),
                new Language(alpha2: "bg", alpha3: "bul", family: "Indo-European", name: "Bulgarian", nativeName: "български език"),
                new Language(alpha2: "bh", alpha3: "bih", family: "Indo-European", name: "Bihari", nativeName: "भोजपुरी"),
                new Language(alpha2: "bi", alpha3: "bis", family: "Creole", name: "Bislama", nativeName: "Bislama"),
                new Language(alpha2: "bm", alpha3: "bam", family: "Niger–Congo", name: "Bambara", nativeName: "bamanankan"),
                new Language(alpha2: "bn", alpha3: "ben", family: "Indo-European", name: "Bengali, Bangla", nativeName: "বাংলা"),
                new Language(alpha2: "bo", alpha3: "bod", family: "Sino-Tibetan", name: "Tibetan Standard, Tibetan, Central", nativeName: "བོད་ཡིག"),
                new Language(alpha2: "br", alpha3: "bre", family: "Indo-European", name: "Breton", nativeName: "brezhoneg"),
                new Language(alpha2: "bs", alpha3: "bos", family: "Indo-European", name: "Bosnian", nativeName: "bosanski jezik"),
                new Language(alpha2: "ca", alpha3: "cat", family: "Indo-European", name: "Catalan", nativeName: "català"),
                new Language(alpha2: "ce", alpha3: "che", family: "Northeast Caucasian", name: "Chechen", nativeName: "нохчийн мотт"),
                new Language(alpha2: "ch", alpha3: "cha", family: "Austronesian", name: "Chamorro", nativeName: "Chamoru"),
                new Language(alpha2: "co", alpha3: "cos", family: "Indo-European", name: "Corsican", nativeName: "corsu, lingua corsa"),
                new Language(alpha2: "cr", alpha3: "cre", family: "Algonquian", name: "Cree", nativeName: "ᓀᐦᐃᔭᐍᐏᐣ"),
                new Language(alpha2: "cs", alpha3: "ces", family: "Indo-European", name: "Czech", nativeName: "čeština, český jazyk"),
                new Language(alpha2: "cu", alpha3: "chu", family: "Indo-European", name: "Old Church Slavonic, Church Slavonic, Old Bulgarian", nativeName: "ѩзыкъ словѣньскъ"),
                new Language(alpha2: "cv", alpha3: "chv", family: "Turkic", name: "Chuvash", nativeName: "чӑваш чӗлхи"),
                new Language(alpha2: "cy", alpha3: "cym", family: "Indo-European", name: "Welsh", nativeName: "Cymraeg"),
                new Language(alpha2: "da", alpha3: "dan", family: "Indo-European", name: "Danish", nativeName: "dansk"),
                new Language(alpha2: "de", alpha3: "deu", family: "Indo-European", name: "German", nativeName: "Deutsch"),
                new Language(alpha2: "dv", alpha3: "div", family: "Indo-European", name: "Divehi, Dhivehi, Maldivian", nativeName: "ދިވެހި"),
                new Language(alpha2: "dz", alpha3: "dzo", family: "Sino-Tibetan", name: "Dzongkha", nativeName: "རྫོང་ཁ"),
                new Language(alpha2: "ee", alpha3: "ewe", family: "Niger–Congo", name: "Ewe", nativeName: "Eʋegbe"),
                new Language(alpha2: "el", alpha3: "ell", family: "Indo-European", name: "Greek (modern)", nativeName: "ελληνικά"),
                new Language(alpha2: "en", alpha3: "eng", family: "Indo-European", name: "English", nativeName: "English"),
                new Language(alpha2: "eo", alpha3: "epo", family: "Constructed", name: "Esperanto", nativeName: "Esperanto"),
                new Language(alpha2: "es", alpha3: "spa", family: "Indo-European", name: "Spanish", nativeName: "Español"),
                new Language(alpha2: "et", alpha3: "est", family: "Uralic", name: "Estonian", nativeName: "eesti, eesti keel"),
                new Language(alpha2: "eu", alpha3: "eus", family: "Language isolate", name: "Basque", nativeName: "euskara, euskera"),
                new Language(alpha2: "fa", alpha3: "fas", family: "Indo-European", name: "Persian (Farsi)", nativeName: "فارسی"),
                new Language(alpha2: "ff", alpha3: "ful", family: "Niger–Congo", name: "Fula, Fulah, Pulaar, Pular", nativeName: "Fulfulde, Pulaar, Pular"),
                new Language(alpha2: "fi", alpha3: "fin", family: "Uralic", name: "Finnish", nativeName: "suomi, suomen kieli"),
                new Language(alpha2: "fj", alpha3: "fij", family: "Austronesian", name: "Fijian", nativeName: "vosa Vakaviti"),
                new Language(alpha2: "fo", alpha3: "fao", family: "Indo-European", name: "Faroese", nativeName: "føroyskt"),
                new Language(alpha2: "fr", alpha3: "fra", family: "Indo-European", name: "French", nativeName: "français, langue française"),
                new Language(alpha2: "fy", alpha3: "fry", family: "Indo-European", name: "Western Frisian", nativeName: "Frysk"),
                new Language(alpha2: "ga", alpha3: "gle", family: "Indo-European", name: "Irish", nativeName: "Gaeilge"),
                new Language(alpha2: "gd", alpha3: "gla", family: "Indo-European", name: "Scottish Gaelic, Gaelic", nativeName: "Gàidhlig"),
                new Language(alpha2: "gl", alpha3: "glg", family: "Indo-European", name: "Galician", nativeName: "galego"),
                new Language(alpha2: "gn", alpha3: "grn", family: "Tupian", name: "Guaraní", nativeName: "Avañe'ẽ"),
                new Language(alpha2: "gu", alpha3: "guj", family: "Indo-European", name: "Gujarati", nativeName: "ગુજરાતી"),
                new Language(alpha2: "gv", alpha3: "glv", family: "Indo-European", name: "Manx", nativeName: "Gaelg, Gailck"),
                new Language(alpha2: "ha", alpha3: "hau", family: "Afro-Asiatic", name: "Hausa", nativeName: "(Hausa) هَوُسَ"),
                new Language(alpha2: "he", alpha3: "heb", family: "Afro-Asiatic", name: "Hebrew (modern)", nativeName: "עברית"),
                new Language(alpha2: "hi", alpha3: "hin", family: "Indo-European", name: "Hindi", nativeName: "हिन्दी, हिंदी"),
                new Language(alpha2: "ho", alpha3: "hmo", family: "Austronesian", name: "Hiri Motu", nativeName: "Hiri Motu"),
                new Language(alpha2: "hr", alpha3: "hrv", family: "Indo-European", name: "Croatian", nativeName: "hrvatski jezik"),
                new Language(alpha2: "ht", alpha3: "hat", family: "Creole", name: "Haitian, Haitian Creole", nativeName: "Kreyòl ayisyen"),
                new Language(alpha2: "hu", alpha3: "hun", family: "Uralic", name: "Hungarian", nativeName: "magyar"),
                new Language(alpha2: "hy", alpha3: "hye", family: "Indo-European", name: "Armenian", nativeName: "Հայերեն"),
                new Language(alpha2: "hz", alpha3: "her", family: "Niger–Congo", name: "Herero", nativeName: "Otjiherero"),
                new Language(alpha2: "ia", alpha3: "ina", family: "Constructed", name: "Interlingua", nativeName: "Interlingua"),
                new Language(alpha2: "id", alpha3: "ind", family: "Austronesian", name: "Indonesian", nativeName: "Bahasa Indonesia"),
                new Language(alpha2: "ie", alpha3: "ile", family: "Constructed", name: "Interlingue", nativeName: "Originally called Occidental; then Interlingue after WWII"),
                new Language(alpha2: "ig", alpha3: "ibo", family: "Niger–Congo", name: "Igbo", nativeName: "Asụsụ Igbo"),
                new Language(alpha2: "ii", alpha3: "iii", family: "Sino-Tibetan", name: "Nuosu", nativeName: "ꆈꌠ꒿ Nuosuhxop"),
                new Language(alpha2: "ik", alpha3: "ipk", family: "Eskimo–Aleut", name: "Inupiaq", nativeName: "Iñupiaq, Iñupiatun"),
                new Language(alpha2: "io", alpha3: "ido", family: "Constructed", name: "Ido", nativeName: "Ido"),
                new Language(alpha2: "is", alpha3: "isl", family: "Indo-European", name: "Icelandic", nativeName: "Íslenska"),
                new Language(alpha2: "it", alpha3: "ita", family: "Indo-European", name: "Italian", nativeName: "Italiano"),
                new Language(alpha2: "iu", alpha3: "iku", family: "Eskimo–Aleut", name: "Inuktitut", nativeName: "ᐃᓄᒃᑎᑐᑦ"),
                new Language(alpha2: "ja", alpha3: "jpn", family: "Japonic", name: "Japanese", nativeName: "日本語 (にほんご)"),
                new Language(alpha2: "jv", alpha3: "jav", family: "Austronesian", name: "Javanese", nativeName: "ꦧꦱꦗꦮ, Basa Jawa"),
                new Language(alpha2: "ka", alpha3: "kat", family: "South Caucasian", name: "Georgian", nativeName: "ქართული"),
                new Language(alpha2: "kg", alpha3: "kon", family: "Niger–Congo", name: "Kongo", nativeName: "Kikongo"),
                new Language(alpha2: "ki", alpha3: "kik", family: "Niger–Congo", name: "Kikuyu, Gikuyu", nativeName: "Gĩkũyũ"),
                new Language(alpha2: "kj", alpha3: "kua", family: "Niger–Congo", name: "Kwanyama, Kuanyama", nativeName: "Kuanyama"),
                new Language(alpha2: "kk", alpha3: "kaz", family: "Turkic", name: "Kazakh", nativeName: "қазақ тілі"),
                new Language(alpha2: "kl", alpha3: "kal", family: "Eskimo–Aleut", name: "Kalaallisut, Greenlandic", nativeName: "kalaallisut, kalaallit oqaasii"),
                new Language(alpha2: "km", alpha3: "khm", family: "Austroasiatic", name: "Khmer", nativeName: "ខ្មែរ, ខេមរភាសា, ភាសាខ្មែរ"),
                new Language(alpha2: "kn", alpha3: "kan", family: "Dravidian", name: "Kannada", nativeName: "ಕನ್ನಡ"),
                new Language(alpha2: "ko", alpha3: "kor", family: "Koreanic", name: "Korean", nativeName: "한국어"),
                new Language(alpha2: "kr", alpha3: "kau", family: "Nilo-Saharan", name: "Kanuri", nativeName: "Kanuri"),
                new Language(alpha2: "ks", alpha3: "kas", family: "Indo-European", name: "Kashmiri", nativeName: "कश्मीरी, كشميري‎"),
                new Language(alpha2: "ku", alpha3: "kur", family: "Indo-European", name: "Kurdish", nativeName: "Kurdî, كوردی‎"),
                new Language(alpha2: "kv", alpha3: "kom", family: "Uralic", name: "Komi", nativeName: "коми кыв"),
                new Language(alpha2: "kw", alpha3: "cor", family: "Indo-European", name: "Cornish", nativeName: "Kernewek"),
                new Language(alpha2: "ky", alpha3: "kir", family: "Turkic", name: "Kyrgyz", nativeName: "Кыргызча, Кыргыз тили"),
                new Language(alpha2: "la", alpha3: "lat", family: "Indo-European", name: "Latin", nativeName: "latine, lingua latina"),
                new Language(alpha2: "lb", alpha3: "ltz", family: "Indo-European", name: "Luxembourgish, Letzeburgesch", nativeName: "Lëtzebuergesch"),
                new Language(alpha2: "lg", alpha3: "lug", family: "Niger–Congo", name: "Ganda", nativeName: "Luganda"),
                new Language(alpha2: "li", alpha3: "lim", family: "Indo-European", name: "Limburgish, Limburgan, Limburger", nativeName: "Limburgs"),
                new Language(alpha2: "ln", alpha3: "lin", family: "Niger–Congo", name: "Lingala", nativeName: "Lingála"),
                new Language(alpha2: "lo", alpha3: "lao", family: "Tai–Kadai", name: "Lao", nativeName: "ພາສາລາວ"),
                new Language(alpha2: "lt", alpha3: "lit", family: "Indo-European", name: "Lithuanian", nativeName: "lietuvių kalba"),
                new Language(alpha2: "lu", alpha3: "lub", family: "Niger–Congo", name: "Luba-Katanga", nativeName: "Tshiluba"),
                new Language(alpha2: "lv", alpha3: "lav", family: "Indo-European", name: "Latvian", nativeName: "latviešu valoda"),
                new Language(alpha2: "mg", alpha3: "mlg", family: "Austronesian", name: "Malagasy", nativeName: "fiteny malagasy"),
                new Language(alpha2: "mh", alpha3: "mah", family: "Austronesian", name: "Marshallese", nativeName: "Kajin M̧ajeļ"),
                new Language(alpha2: "mi", alpha3: "mri", family: "Austronesian", name: "Māori", nativeName: "te reo Māori"),
                new Language(alpha2: "mk", alpha3: "mkd", family: "Indo-European", name: "Macedonian", nativeName: "македонски јазик"),
                new Language(alpha2: "ml", alpha3: "mal", family: "Dravidian", name: "Malayalam", nativeName: "മലയാളം"),
                new Language(alpha2: "mn", alpha3: "mon", family: "Mongolic", name: "Mongolian", nativeName: "Монгол хэл"),
                new Language(alpha2: "mr", alpha3: "mar", family: "Indo-European", name: "Marathi (Marāṭhī)", nativeName: "मराठी"),
                new Language(alpha2: "ms", alpha3: "msa", family: "Austronesian", name: "Malay", nativeName: "bahasa Melayu, بهاس ملايو‎"),
                new Language(alpha2: "mt", alpha3: "mlt", family: "Afro-Asiatic", name: "Maltese", nativeName: "Malti"),
                new Language(alpha2: "my", alpha3: "mya", family: "Sino-Tibetan", name: "Burmese", nativeName: "ဗမာစာ"),
                new Language(alpha2: "na", alpha3: "nau", family: "Austronesian", name: "Nauruan", nativeName: "Dorerin Naoero"),
                new Language(alpha2: "nb", alpha3: "nob", family: "Indo-European", name: "Norwegian Bokmål", nativeName: "Norsk bokmål"),
                new Language(alpha2: "nd", alpha3: "nde", family: "Niger–Congo", name: "Northern Ndebele", nativeName: "isiNdebele"),
                new Language(alpha2: "ne", alpha3: "nep", family: "Indo-European", name: "Nepali", nativeName: "नेपाली"),
                new Language(alpha2: "ng", alpha3: "ndo", family: "Niger–Congo", name: "Ndonga", nativeName: "Owambo"),
                new Language(alpha2: "nl", alpha3: "nld", family: "Indo-European", name: "Dutch", nativeName: "Nederlands, Vlaams"),
                new Language(alpha2: "nn", alpha3: "nno", family: "Indo-European", name: "Norwegian Nynorsk", nativeName: "Norsk nynorsk"),
                new Language(alpha2: "no", alpha3: "nor", family: "Indo-European", name: "Norwegian", nativeName: "Norsk"),
                new Language(alpha2: "nr", alpha3: "nbl", family: "Niger–Congo", name: "Southern Ndebele", nativeName: "isiNdebele"),
                new Language(alpha2: "nv", alpha3: "nav", family: "Dené–Yeniseian", name: "Navajo, Navaho", nativeName: "Diné bizaad"),
                new Language(alpha2: "ny", alpha3: "nya", family: "Niger–Congo", name: "Chichewa, Chewa, Nyanja", nativeName: "chiCheŵa, chinyanja"),
                new Language(alpha2: "oc", alpha3: "oci", family: "Indo-European", name: "Occitan", nativeName: "occitan, lenga d'òc"),
                new Language(alpha2: "oj", alpha3: "oji", family: "Algonquian", name: "Ojibwe, Ojibwa", nativeName: "ᐊᓂᔑᓈᐯᒧᐎᓐ"),
                new Language(alpha2: "om", alpha3: "orm", family: "Afro-Asiatic", name: "Oromo", nativeName: "Afaan Oromoo"),
                new Language(alpha2: "or", alpha3: "ori", family: "Indo-European", name: "Oriya", nativeName: "ଓଡ଼ିଆ"),
                new Language(alpha2: "os", alpha3: "oss", family: "Indo-European", name: "Ossetian, Ossetic", nativeName: "ирон æвзаг"),
                new Language(alpha2: "pa", alpha3: "pan", family: "Indo-European", name: "(Eastern) Punjabi", nativeName: "ਪੰਜਾਬੀ"),
                new Language(alpha2: "pi", alpha3: "pli", family: "Indo-European", name: "Pāli", nativeName: "पाऴि"),
                new Language(alpha2: "pl", alpha3: "pol", family: "Indo-European", name: "Polish", nativeName: "język polski, polszczyzna"),
                new Language(alpha2: "ps", alpha3: "pus", family: "Indo-European", name: "Pashto, Pushto", nativeName: "پښتو"),
                new Language(alpha2: "pt", alpha3: "por", family: "Indo-European", name: "Portuguese", nativeName: "Português"),
                new Language(alpha2: "qu", alpha3: "que", family: "Quechuan", name: "Quechua", nativeName: "Runa Simi, Kichwa"),
                new Language(alpha2: "rm", alpha3: "roh", family: "Indo-European", name: "Romansh", nativeName: "rumantsch grischun"),
                new Language(alpha2: "rn", alpha3: "run", family: "Niger–Congo", name: "Kirundi", nativeName: "Ikirundi"),
                new Language(alpha2: "ro", alpha3: "ron", family: "Indo-European", name: "Romanian", nativeName: "Română"),
                new Language(alpha2: "ru", alpha3: "rus", family: "Indo-European", name: "Russian", nativeName: "Русский"),
                new Language(alpha2: "rw", alpha3: "kin", family: "Niger–Congo", name: "Kinyarwanda", nativeName: "Ikinyarwanda"),
                new Language(alpha2: "sa", alpha3: "san", family: "Indo-European", name: "Sanskrit (Saṁskṛta)", nativeName: "संस्कृतम्"),
                new Language(alpha2: "sc", alpha3: "srd", family: "Indo-European", name: "Sardinian", nativeName: "sardu"),
                new Language(alpha2: "sd", alpha3: "snd", family: "Indo-European", name: "Sindhi", nativeName: "सिन्धी, سنڌي، سندھی‎"),
                new Language(alpha2: "se", alpha3: "sme", family: "Uralic", name: "Northern Sami", nativeName: "Davvisámegiella"),
                new Language(alpha2: "sg", alpha3: "sag", family: "Creole", name: "Sango", nativeName: "yângâ tî sängö"),
                new Language(alpha2: "si", alpha3: "sin", family: "Indo-European", name: "Sinhalese, Sinhala", nativeName: "සිංහල"),
                new Language(alpha2: "sk", alpha3: "slk", family: "Indo-European", name: "Slovak", nativeName: "slovenčina, slovenský jazyk"),
                new Language(alpha2: "sl", alpha3: "slv", family: "Indo-European", name: "Slovene", nativeName: "slovenski jezik, slovenščina"),
                new Language(alpha2: "sm", alpha3: "smo", family: "Austronesian", name: "Samoan", nativeName: "gagana fa'a Samoa"),
                new Language(alpha2: "sn", alpha3: "sna", family: "Niger–Congo", name: "Shona", nativeName: "chiShona"),
                new Language(alpha2: "so", alpha3: "som", family: "Afro-Asiatic", name: "Somali", nativeName: "Soomaaliga, af Soomaali"),
                new Language(alpha2: "sq", alpha3: "sqi", family: "Indo-European", name: "Albanian", nativeName: "Shqip"),
                new Language(alpha2: "sr", alpha3: "srp", family: "Indo-European", name: "Serbian", nativeName: "српски језик"),
                new Language(alpha2: "ss", alpha3: "ssw", family: "Niger–Congo", name: "Swati", nativeName: "SiSwati"),
                new Language(alpha2: "st", alpha3: "sot", family: "Niger–Congo", name: "Southern Sotho", nativeName: "Sesotho"),
                new Language(alpha2: "su", alpha3: "sun", family: "Austronesian", name: "Sundanese", nativeName: "Basa Sunda"),
                new Language(alpha2: "sv", alpha3: "swe", family: "Indo-European", name: "Swedish", nativeName: "svenska"),
                new Language(alpha2: "sw", alpha3: "swa", family: "Niger–Congo", name: "Swahili", nativeName: "Kiswahili"),
                new Language(alpha2: "ta", alpha3: "tam", family: "Dravidian", name: "Tamil", nativeName: "தமிழ்"),
                new Language(alpha2: "te", alpha3: "tel", family: "Dravidian", name: "Telugu", nativeName: "తెలుగు"),
                new Language(alpha2: "tg", alpha3: "tgk", family: "Indo-European", name: "Tajik", nativeName: "тоҷикӣ, toçikī, تاجیکی‎"),
                new Language(alpha2: "th", alpha3: "tha", family: "Tai–Kadai", name: "Thai", nativeName: "ไทย"),
                new Language(alpha2: "ti", alpha3: "tir", family: "Afro-Asiatic", name: "Tigrinya", nativeName: "ትግርኛ"),
                new Language(alpha2: "tk", alpha3: "tuk", family: "Turkic", name: "Turkmen", nativeName: "Türkmen, Түркмен"),
                new Language(alpha2: "tl", alpha3: "tgl", family: "Austronesian", name: "Tagalog", nativeName: "Wikang Tagalog"),
                new Language(alpha2: "tn", alpha3: "tsn", family: "Niger–Congo", name: "Tswana", nativeName: "Setswana"),
                new Language(alpha2: "to", alpha3: "ton", family: "Austronesian", name: "Tonga (Tonga Islands)", nativeName: "faka Tonga"),
                new Language(alpha2: "tr", alpha3: "tur", family: "Turkic", name: "Turkish", nativeName: "Türkçe"),
                new Language(alpha2: "ts", alpha3: "tso", family: "Niger–Congo", name: "Tsonga", nativeName: "Xitsonga"),
                new Language(alpha2: "tt", alpha3: "tat", family: "Turkic", name: "Tatar", nativeName: "татар теле, tatar tele"),
                new Language(alpha2: "tw", alpha3: "twi", family: "Niger–Congo", name: "Twi", nativeName: "Twi"),
                new Language(alpha2: "ty", alpha3: "tah", family: "Austronesian", name: "Tahitian", nativeName: "Reo Tahiti"),
                new Language(alpha2: "ug", alpha3: "uig", family: "Turkic", name: "Uyghur", nativeName: "ئۇيغۇرچە‎, Uyghurche"),
                new Language(alpha2: "uk", alpha3: "ukr", family: "Indo-European", name: "Ukrainian", nativeName: "Українська"),
                new Language(alpha2: "ur", alpha3: "urd", family: "Indo-European", name: "Urdu", nativeName: "اردو"),
                new Language(alpha2: "uz", alpha3: "uzb", family: "Turkic", name: "Uzbek", nativeName: "Oʻzbek, Ўзбек, أۇزبېك‎"),
                new Language(alpha2: "ve", alpha3: "ven", family: "Niger–Congo", name: "Venda", nativeName: "Tshivenḓa"),
                new Language(alpha2: "vi", alpha3: "vie", family: "Austroasiatic", name: "Vietnamese", nativeName: "Tiếng Việt"),
                new Language(alpha2: "vo", alpha3: "vol", family: "Constructed", name: "Volapük", nativeName: "Volapük"),
                new Language(alpha2: "wa", alpha3: "wln", family: "Indo-European", name: "Walloon", nativeName: "walon"),
                new Language(alpha2: "wo", alpha3: "wol", family: "Niger–Congo", name: "Wolof", nativeName: "Wollof"),
                new Language(alpha2: "xh", alpha3: "xho", family: "Niger–Congo", name: "Xhosa", nativeName: "isiXhosa"),
                new Language(alpha2: "yi", alpha3: "yid", family: "Indo-European", name: "Yiddish", nativeName: "ייִדיש"),
                new Language(alpha2: "yo", alpha3: "yor", family: "Niger–Congo", name: "Yoruba", nativeName: "Yorùbá"),
                new Language(alpha2: "za", alpha3: "zha", family: "Tai–Kadai", name: "Zhuang, Chuang", nativeName: "Saɯ cueŋƅ, Saw cuengh"),
                new Language(alpha2: "zh", alpha3: "zho", family: "Sino-Tibetan", name: "Chinese", nativeName: "中文 (Zhōngwén), 汉语, 漢語"),
                new Language(alpha2: "zu", alpha3: "zul", family: "Niger–Congo", name: "Zulu", nativeName: "isiZulu"),
            };
        }
    }
}
