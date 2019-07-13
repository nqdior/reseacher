﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reseacher.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MyResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MyResource() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Reseacher.Core.Properties.MyResource", typeof(MyResource).Assembly);
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
        ///   SELECT
        ///    T.TABLE_SCHEMA AS &apos;SCHEMA&apos;,
        ///	COUNT(*) AS &apos;TABLECOUNT&apos;
        ///FROM
        ///    INFORMATION_SCHEMA.TABLES T
        ///GROUP BY
        ///	T.TABLE_SCHEMA
        ///; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SCHEMAS {
            get {
                return ResourceManager.GetString("SCHEMAS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   SELECT
        ///    T.TABLE_SCHEMA AS &apos;SCHEMA&apos;,
        ///	T.TABLE_NAME AS &apos;TABLE&apos;,
        ///	T.TABLE_ROWS AS &apos;ROWCOUNT&apos;,
        ///	C.TABLE_COLUMNS AS &apos;COLUMNCOUNT&apos;
        ///FROM
        ///    INFORMATION_SCHEMA.TABLES T
        ///	INNER JOIN
        ///	(
        ///	SELECT
        ///		TABLE_SCHEMA,
        ///		TABLE_NAME,
        ///		COUNT(*) AS TABLE_COLUMNS
        ///	FROM
        ///		INFORMATION_SCHEMA.COLUMNS
        ///	GROUP BY
        ///		TABLE_SCHEMA,
        ///		TABLE_NAME
        ///	) C
        ///	ON T.TABLE_SCHEMA = C.TABLE_SCHEMA AND T.TABLE_NAME = C.TABLE_NAME
        ///
        ///WHERE
        ///T.TABLE_SCHEMA = &apos;{0}&apos;
        ///; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TABLES {
            get {
                return ResourceManager.GetString("TABLES", resourceCulture);
            }
        }
    }
}