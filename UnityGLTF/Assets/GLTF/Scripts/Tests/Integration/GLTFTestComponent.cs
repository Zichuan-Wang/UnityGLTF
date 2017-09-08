﻿using UnityEngine;
using System.Collections;
using GLTF.Unity;

public class GLTFTestComponent : MonoBehaviour {
	public string Url;
	public bool Multithreaded = true;

	public Shader GLTFStandard;


	IEnumerator Start()
	{
		var loader = new GLTFSceneImporter(
			Url,
			gameObject.transform
			);

		loader.SetShaderForMaterialType(GLTFSceneImporter.MaterialType.PbrMetallicRoughness, GLTFStandard);
		yield return loader.Load(-1, Multithreaded);
		IntegrationTest.Pass();
	}
}