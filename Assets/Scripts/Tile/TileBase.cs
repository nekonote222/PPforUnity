﻿using UnityEngine;
using System.Collections;

public class TileBase : MonoBehaviour {

	private Color default_color;	// 初期化カラー
	private Color select_color;		// 選択時カラー

	protected Material _material;

	public bool bColorState;

	// Use this for initialization
	void Start () {
		// このクラスが付属しているマテリアルを取得
		_material = this.gameObject.GetComponent<Renderer>().material;
		// 選択時と非選択時のカラーを保持
		default_color = _material.color;
		select_color = Color.magenta;
		bColorState = false;
	}
	
	// Update is called once per frame
	void Update () {
		_material.color = default_color;
		// StageBaseからbColorStateの値がtrueにされていれば色を変える
		if (bColorState) {
			bColorState = false;
			_material.color = select_color;
		}
	}
}
