﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpeechTelop.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SpeechTelop.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Alt +  に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AddAltKeyText {
            get {
                return ResourceManager.GetString("AddAltKeyText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ctrl +  に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AddCtrlKeyText {
            get {
                return ResourceManager.GetString("AddCtrlKeyText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Shift +  に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AddShiftKeyText {
            get {
                return ResourceManager.GetString("AddShiftKeyText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   LButton,RButton,MButton,Back,Tab,Enter,Escape,Space,PageUp,PageDown,End,Home,Left,Up,Right,Down,Insert,Delete,D0,D1,D2,D3,D4,D5,D6,D7,D8,D9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,NumPad0,NumPad1,NumPad2,NumPad3,NumPad4,NumPad5,NumPad6,NumPad7,NumPad8,NumPad9,Multiply,Add,Subtract,Decimal,Divide,F1,F2,F3,F4,F5,F6,F7,F8,F9,F10,F11,F12 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string HotKeys {
            get {
                return ResourceManager.GetString("HotKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   {
        ///  &quot;language_data&quot;:[
        ///    {
        ///      &quot;speech_translation_from_language&quot;: &quot;ar&quot;,
        ///      &quot;speech_translation_to_language&quot;: &quot;ar&quot;,
        ///      &quot;text_to_speech_locale&quot;: &quot;ar-EG&quot;,
        ///      &quot;voice_name&quot;: [
        ///        { &quot;gender&quot;:&quot;Female&quot;, &quot;name&quot;:&quot;ar-EG-Hoda&quot; },
        ///      ],
        ///    },
        ///    {
        ///      &quot;speech_translation_from_language&quot;: &quot;zh-Hans&quot;,
        ///      &quot;speech_translation_to_language&quot;: &quot;zh-Hans&quot;,
        ///      &quot;text_to_speech_locale&quot;: &quot;zh-CN&quot;,
        ///      &quot;voice_name&quot;: [
        ///        { &quot;gender&quot;:&quot;Female&quot;, &quot;name&quot;:&quot;zh-CN-HuihuiRUS&quot; },
        ///        { &quot;gend [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string LanguageSupport {
            get {
                return ResourceManager.GetString("LanguageSupport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   westus,westus2,eastus,eastus2,eastasia,japaneast,southeastasia,northeurope,westeurope に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SpeechServiceRegion {
            get {
                return ResourceManager.GetString("SpeechServiceRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   SpeechTelop に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string VoiceName {
            get {
                return ResourceManager.GetString("VoiceName", resourceCulture);
            }
        }
    }
}