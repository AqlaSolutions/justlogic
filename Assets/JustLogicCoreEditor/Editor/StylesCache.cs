﻿using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;
using System.Linq;

namespace JustLogic.Editor
{
    public class StylesCache
    {
        static GUISkin _darkSkin;
        static GUISkin _whiteSkin;

        public static GUISkin Skin
        {
            get
            {
                return GUI.skin;
                if (EditorGUIUtility.isProSkin)
                    return _darkSkin ?? (_darkSkin = (GUISkin)AssetDatabase.LoadAssetAtPath("Assets/JustLogic/DarkSkin.guiskin", typeof(GUISkin)));
                return _whiteSkin ?? (_whiteSkin = (GUISkin)AssetDatabase.LoadAssetAtPath("Assets/JustLogic/WhiteSkin.guiskin", typeof(GUISkin)));
            }
        }

        public static bool InspectorMode { get; set; }

        public static void LookLikeInspector()
        {
            EditorGUIUtility.LookLikeInspector();
            InspectorMode = true;
        }

        public static void LookLikeControls()
        {
            EditorGUIUtility.LookLikeControls();
            InspectorMode = false;
        }

        //static GUIStyle GetStyleP(string style)
        //{
        //    if (InspectorMode)
        //        style = "IN " + style;
        //    return Skin.GetStyle(style);
        //}

        //public static GUIStyle numberField { get { return GetStyleP("textField"); } }
        //public static GUIStyle textField { get { return GetStyleP("textField"); } }
        //public static GUIStyle objectField { get { return GetStyleP("ObjectField"); } }
        //public static GUIStyle box { get { return Skin.box; } }

        //public static GUIStyle label { get { return Skin.GetStyle(InspectorMode ? "IN Label" : "ControlLabel"); } }

        //public static GUIStyle objectFieldThumb { get { return Skin.GetStyle(InspectorMode ? "IN ObjectField" : "ObjectFieldThumb"); } }

        //public static GUIStyle foldoutPreDrop { get { return Skin.GetStyle("FoldoutPreDrop"); } }

        //public static GUIStyle button { get { return Skin.button; } }

        //public static GUIStyle boldLabel { get { return Skin.GetStyle("BoldLabel"); } }

        //public static GUIStyle foldout { get { return GetStyleP("Foldout"); } }

        //public static GUIStyle layerMaskField { get { return Skin.GetStyle(InspectorMode ? "IN Popup" : "MiniPopup"); } }

        //static GUIStyle _toggleInspector;

        //public static GUIStyle toggle
        //{
        //    get
        //    {
        //        if (!InspectorMode)
        //            return Skin.GetStyle("Toggle");
        //        return _toggleInspector ?? (_toggleInspector = new GUIStyle(Skin.GetStyle("Toggle")) { margin = { top = 0 }, padding = { top = 0 }, overflow = { top = 0 } });
        //    }
        //}

        //public static GUIStyle ColorField { get { return GetStyleP("ColorField"); } }

        //static GUIStyle _inPopup;

        //public static GUIStyle popup
        //{
        //    get
        //    {
        //        if (_inPopup == null)
        //        {
        //            _inPopup = new GUIStyle(Skin/*EditorGUIUtility.GetBuiltinSkin(EditorSkin.Inspector)*/.GetStyle("IN Popup"))
        //                                  {
        //                                      fontStyle = FontStyle.Bold,
        //                                      alignment = TextAnchor.MiddleLeft
        //                                  };
        //            GUIStyleState state = _inPopup.normal;
        //            state.textColor = GUI.color;
        //            _inPopup.active = _inPopup.onActive = _inPopup.onNormal = _inPopup.focused = _inPopup.onFocused = _inPopup.hover = _inPopup.onHover;
        //        }
        //        return InspectorMode ? _inPopup : Skin.GetStyle("MiniPopup");
        //    }
        //}
        static GUIStyle GetStyleP(string style)
        {
            if (InspectorMode)
                style = "IN " + style;

            switch (style)
            {
                case "Toggle":
                case "toggle":
                    return Skin.toggle;
                case "textField":
                    return Skin.textField;

            }

            return Skin.GetStyle(style);
        }

        public static GUIStyle numberField { get { return GetStyleP("textField"); } }
        public static GUIStyle textField { get { return GetStyleP("textField"); } }
        public static GUIStyle objectField { get { return GetStyleP("ObjectField"); } }
        public static GUIStyle box { get { return Skin.box; } }

        public static GUIStyle label { get { return Skin.GetStyle(InspectorMode ? "IN Label" : "ControlLabel"); } }

        public static GUIStyle objectFieldThumb { get { return Skin.GetStyle(InspectorMode ? "IN ObjectField" : "ObjectFieldThumb"); } }

        public static GUIStyle foldoutPreDrop { get { return Skin.GetStyle("FoldoutPreDrop"); } }

        public static GUIStyle button { get { return Skin.button; } }

        public static GUIStyle boldLabel { get { return Skin.GetStyle("BoldLabel"); } }

        public static GUIStyle foldout { get { return GetStyleP("Foldout"); } }

        public static GUIStyle layerMaskField { get { return Skin.GetStyle(InspectorMode ? "IN Popup" : "MiniPopup"); } }

        static GUIStyle _toggleInspector;

        public static GUIStyle toggle
        {
            get
            {
                if (!InspectorMode)
                    return Skin.GetStyle("Toggle");
                return _toggleInspector ?? (_toggleInspector = new GUIStyle(Skin.GetStyle("Toggle")) { margin = { top = 0 }, padding = { top = 0 }, overflow = { top = 0 } });
            }
        }

        public static GUIStyle ColorField { get { return GetStyleP("ColorField"); } }

        static GUIStyle _inPopup;

        public static GUIStyle popup
        {
            get
            {
                if (_inPopup == null)
                {
                    _inPopup = new GUIStyle(Skin/*EditorGUIUtility.GetBuiltinSkin(EditorSkin.Inspector)*/.GetStyle("IN Popup"))
                                          {
                                              fontStyle = FontStyle.Bold,
                                              alignment = TextAnchor.MiddleLeft
                                          };
                    GUIStyleState state = _inPopup.normal;
                    state.textColor = GUI.color;
                    _inPopup.active = _inPopup.onActive = _inPopup.onNormal = _inPopup.focused = _inPopup.onFocused = _inPopup.hover = _inPopup.onHover;
                }
                return InspectorMode ? _inPopup : Skin.GetStyle("MiniPopup");
            }
        }
    }
}

/*
        static GUISkin _savedInspectorSkin;
        static GUISkin _savedControlsSkin;

        static bool _drawing;
        static void SetStyles()
        {
            if (!_drawing) return;
            GUISkin skin = EditorGUIUtility.GetBuiltinSkin(EditorSkin.Inspector);
            skin.box = box;
            skin.label = label;
            skin.button = button;
            for (int i = 0; i < skin.customStyles.Length; i++)
            {
                var name = skin.customStyles[i].name;
                switch (name)
                {
                    case "IN textField":
                    case "textField":
                        skin.customStyles[i] = textField;
                        break;
                    case "ObjectField":
                        skin.customStyles[i] = objectField;
                        break;
                    case "IN ObjectField":
                    case "ObjectFieldThumb":
                        skin.customStyles[i] = objectField;
                        break;
                    case "FoldoutPreDrop":
                        skin.customStyles[i] = foldoutPreDrop;
                        break;
                    case "BoldLabel":
                        skin.customStyles[i] = boldLabel;
                        break;
                    case "Foldout":
                    case "IN Foldout":
                        skin.customStyles[i] = foldout;
                        break;
                    case "IN Popup":
                    case "MiniPopup":
                        skin.customStyles[i] = layerMaskField;
                        break;
                    case "Toggle":
                    case "IN Toggle":
                        skin.customStyles[i] = toggle;
                        break;
                    case "ColorField":
                    case "IN ColorField":
                        skin.customStyles[i] = ColorField;
                        break;
                }

            }

        }
        
        public void StartDrawing()
        {
            if (_drawing) throw new InvalidOperationException();
            if (!_savedInspectorSkin || !_savedControlsSkin)
            {
                EditorGUIUtility.LookLikeInspector();
                _savedInspectorSkin = (GUISkin)Object.Instantiate(EditorGUIUtility.GetBuiltinSkin(EditorSkin.Inspector));
                EditorGUIUtility.LookLikeControls();
                _savedControlsSkin = (GUISkin)Object.Instantiate(EditorGUIUtility.GetBuiltinSkin(EditorSkin.Inspector));
                if (InspectorMode)
                    EditorGUIUtility.LookLikeInspector();
            }
            _drawing = true;
            SetStyles();
        }

        public void EndDrawing()
        {
            if (!_drawing) throw new InvalidOperationException();
            _drawing = false;
            EditorGUIUtility.LookLikeInspector();
            GUISkin skin = EditorGUIUtility.GetBuiltinSkin(EditorSkin.Inspector);
            skin.box = box;
            skin.FindStyle(.GetEnumerator()
            foreach (var VARIABLE in skin)
            {
                
            }
            skin.label = label;
            skin.button = button;
            for (int i = 0; i < skin.customStyles.Length; i++)
            {
                var name = skin.customStyles[i].name;
                switch (name)
                {
                    case "IN textField":
                        skin.customStyles[i] = textField;
                    case "textField":
                        skin.customStyles[i] = textField;
                        break;
                    case "ObjectField":
                        skin.customStyles[i] = objectField;
                        break;
                    case "IN ObjectField":
                    case "ObjectFieldThumb":
                        skin.customStyles[i] = objectField;
                        break;
                    case "FoldoutPreDrop":
                        skin.customStyles[i] = foldoutPreDrop;
                        break;
                    case "BoldLabel":
                        skin.customStyles[i] = boldLabel;
                        break;
                    case "Foldout":
                    case "IN Foldout":
                        skin.customStyles[i] = foldout;
                        break;
                    case "IN Popup":
                    case "MiniPopup":
                        skin.customStyles[i] = layerMaskField;
                        break;
                    case "Toggle":
                    case "IN Toggle":
                        skin.customStyles[i] = toggle;
                        break;
                    case "ColorField":
                    case "IN ColorField":
                        skin.customStyles[i] = ColorField;
                        break;
                }

            }
        }
        */