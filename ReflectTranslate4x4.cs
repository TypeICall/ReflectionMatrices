using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* v = Vertex Count
	 * 
	 * Lettered Abbreviations
		 * T = Tetrahedron
		 * 
		 * O = Octahedron,
		 * C = Cube
		 * CO = Cubocthaedron
		 *
		 * I = Icosahedron
		 * D = IcosaDodecahedron
		 * ID = IcosaDodecahedron
		 * 
		 * t = Truncated
		 * r = Rhombified
		 * 
		 * G or J = Chiralities
	 */
public struct Reflection4x4
{
	public static Matrix4x4[] v6_O(Vector3 t)
	{
		return new Matrix4x4[3] {
				 new Matrix4x4(
					 new Vector4(-1, 0, 0, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -1, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0, 0, -1, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v8_C(Vector3 t)
	{
		return new Matrix4x4[4] {
				new Matrix4x4(
					new Vector4(0.3333333f, -0.6666667f, -0.6666667f, t.x),
					new Vector4(-0.6666667f, 0.3333333f, -0.6666667f, t.y),
					new Vector4(-0.6666667f, -0.6666667f, 0.3333333f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.3333333f, -0.6666667f, 0.6666667f, t.x),
					new Vector4(-0.6666667f, 0.3333333f, 0.6666667f, t.y),
					new Vector4(0.6666667f, 0.6666667f, 0.3333333f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.3333333f, 0.6666667f, -0.6666667f, t.x),
					new Vector4(0.6666667f, 0.3333333f, 0.6666667f, t.y),
					new Vector4(-0.6666667f, 0.6666667f, 0.3333333f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.3333333f, 0.6666667f, 0.6666667f, t.x),
					new Vector4(0.6666667f, 0.3333333f, -0.6666667f, t.y),
					new Vector4(0.6666667f, -0.6666667f, 0.3333333f, t.z),
					new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v12_CO(Vector3 t)
	{
		return new Matrix4x4[6] {
				new Matrix4x4(
					new Vector4(0, -1, 0, t.x),
					new Vector4(-1, 0, 0, t.y),
					new Vector4(0, 0, 1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0, 1, 0, t.x),
					new Vector4(1, 0, 0, t.y),
					new Vector4(0, 0, -1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0, 0, -1, t.x),
					new Vector4(0, 1, 0, t.y),
					new Vector4(-1, 0, 0, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0, 0, 1, t.x),
					new Vector4(0, 1, 0, t.y),
					new Vector4(1, 0, 0, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(1, 0, 0, t.x),
					new Vector4(0, 0, -1, t.y),
					new Vector4(0, -1, 0, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-1, 0, 0, t.x),
					new Vector4(0, 0, 1, t.y),
					new Vector4(0, 1, 0, t.z),
					new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v24_tO(Vector3 t)
	{
		return new Matrix4x4[12] {
				new Matrix4x4(
					new Vector4(-0.6f, -0.8f, 0, t.x),
					new Vector4(-0.8f, 0.6f, 0, t.y),
					new Vector4(0, 0, 1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.6f, 0.8f, 0, t.x),
					new Vector4(0.8f, 0.6f, 0, t.y),
					new Vector4(0, 0, 1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6f, -0.8f, 0, t.x),
					new Vector4(-0.8f, -0.6f, 0, t.y),
					new Vector4(0, 0, 1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6f, 0.8f, 0, t.x),
					new Vector4(0.8f, -0.6f, 0, t.y),
					new Vector4(0, 0, 1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.6f, 0, -0.8f, t.x),
					new Vector4(0, 1, 0, t.y),
					new Vector4(-0.8f, 0, 0.6f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.6f, 0, 0.8f, t.x),
					new Vector4(0, 1, 0, t.y),
					new Vector4(0.8f, 0, 0.6f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6f, 0, -0.8f, t.x),
					new Vector4(0, 1, 0, t.y),
					new Vector4(-0.8f, 0, -0.6f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6f, 0, 0.8f, t.x),
					new Vector4(0, 1, 0, t.y),
					new Vector4(0.8f, 0, -0.6f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(1, 0, 0, t.x),
					new Vector4(0, -0.6f, -0.8f, t.y),
					new Vector4(0, -0.8f, 0.6f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(1, 0, 0, t.x),
					new Vector4(0, -0.6f, 0.8f, t.y),
					new Vector4(0, 0.8f, 0.6f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(1, 0, 0, t.x),
					new Vector4(0, 0.6f, -0.8f, t.y),
					new Vector4(0, -0.8f, -0.6f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(1, 0, 0, t.x),
					new Vector4(0, 0.6f, 0.8f, t.y),
					new Vector4(0, 0.8f, -0.6f, t.z),
					new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v24_tC(Vector3 t)
	{
		return new Matrix4x4[12] {
				new Matrix4x4(
					new Vector4(0.07900857f, -0.9209914f, -0.3814871f, t.x),
					new Vector4(-0.9209914f, 0.07900857f, -0.3814871f, t.y),
					new Vector4(-0.3814871f, -0.3814871f, 0.8419828f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.07900857f, -0.9209914f, 0.3814871f, t.x),
					new Vector4(-0.9209914f, 0.07900857f, 0.3814871f, t.y),
					new Vector4(0.3814871f, 0.3814871f, 0.8419828f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.07900857f, 0.9209914f, -0.3814871f, t.x),
					new Vector4(0.9209914f, 0.07900857f, 0.3814871f, t.y),
					new Vector4(-0.3814871f, 0.3814871f, 0.8419828f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.07900857f, 0.9209914f, 0.3814871f, t.x),
					new Vector4(0.9209914f, 0.07900857f, -0.3814871f, t.y),
					new Vector4(0.3814871f, -0.3814871f, 0.8419828f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.07900857f, -0.3814871f, -0.9209914f, t.x),
					new Vector4(-0.3814871f, 0.8419828f, -0.3814871f, t.y),
					new Vector4(-0.9209914f, -0.3814871f, 0.07900857f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.07900857f, -0.3814871f, 0.9209914f, t.x),
					new Vector4(-0.3814871f, 0.8419828f, 0.3814871f, t.y),
					new Vector4(0.9209914f, 0.3814871f, 0.07900857f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.07900857f, 0.3814871f, -0.9209914f, t.x),
					new Vector4(0.3814871f, 0.8419828f, 0.3814871f, t.y),
					new Vector4(-0.9209914f, 0.3814871f, 0.07900857f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.07900857f, 0.3814871f, 0.9209914f, t.x),
					new Vector4(0.3814871f, 0.8419828f, -0.3814871f, t.y),
					new Vector4(0.9209914f, -0.3814871f, 0.07900857f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8419828f, -0.3814871f, -0.3814871f, t.x),
					new Vector4(-0.3814871f, 0.07900857f, -0.9209914f, t.y),
					new Vector4(-0.3814871f, -0.9209914f, 0.07900857f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8419828f, -0.3814871f, 0.3814871f, t.x),
					new Vector4(-0.3814871f, 0.07900857f, 0.9209914f, t.y),
					new Vector4(0.3814871f, 0.9209914f, 0.07900857f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8419828f, 0.3814871f, -0.3814871f, t.x),
					new Vector4(0.3814871f, 0.07900857f, 0.9209914f, t.y),
					new Vector4(-0.3814871f, 0.9209914f, 0.07900857f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8419828f, 0.3814871f, 0.3814871f, t.x),
					new Vector4(0.3814871f, 0.07900857f, -0.9209914f, t.y),
					new Vector4(0.3814871f, -0.9209914f, 0.07900857f, t.z),
					new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v24_rCO(Vector3 t)
	{
		return new Matrix4x4[12] {
				 new Matrix4x4(
					 new Vector4(-0.4890417f, -0.6167812f, -0.6167812f, t.x),
					 new Vector4(-0.6167812f, 0.7445208f, -0.2554792f, t.y),
					 new Vector4(-0.6167812f, -0.2554792f, 0.7445208f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.4890417f, -0.6167812f, 0.6167812f, t.x),
					 new Vector4(-0.6167812f, 0.7445208f, 0.2554792f, t.y),
					 new Vector4(0.6167812f, 0.2554792f, 0.7445208f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.4890417f, 0.6167812f, -0.6167812f, t.x),
					 new Vector4(0.6167812f, 0.7445208f, 0.2554792f, t.y),
					 new Vector4(-0.6167812f, 0.2554792f, 0.7445208f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.4890417f, 0.6167812f, 0.6167812f, t.x),
					 new Vector4(0.6167812f, 0.7445208f, -0.2554792f, t.y),
					 new Vector4(0.6167812f, -0.2554792f, 0.7445208f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7445208f, -0.6167812f, -0.2554792f, t.x),
					 new Vector4(-0.6167812f, -0.4890417f, -0.6167812f, t.y),
					 new Vector4(-0.2554792f, -0.6167812f, 0.7445208f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7445208f, -0.6167812f, 0.2554792f, t.x),
					 new Vector4(-0.6167812f, -0.4890417f, 0.6167812f, t.y),
					 new Vector4(0.2554792f, 0.6167812f, 0.7445208f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7445208f, 0.6167812f, -0.2554792f, t.x),
					 new Vector4(0.6167812f, -0.4890417f, 0.6167812f, t.y),
					 new Vector4(-0.2554792f, 0.6167812f, 0.7445208f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7445208f, 0.6167812f, 0.2554792f, t.x),
					 new Vector4(0.6167812f, -0.4890417f, -0.6167812f, t.y),
					 new Vector4(0.2554792f, -0.6167812f, 0.7445208f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7445208f, -0.2554792f, -0.6167812f, t.x),
					 new Vector4(-0.2554792f, 0.7445208f, -0.6167812f, t.y),
					 new Vector4(-0.6167812f, -0.6167812f, -0.4890417f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7445208f, -0.2554792f, 0.6167812f, t.x),
					 new Vector4(-0.2554792f, 0.7445208f, 0.6167812f, t.y),
					 new Vector4(0.6167812f, 0.6167812f, -0.4890417f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7445208f, 0.2554792f, -0.6167812f, t.x),
					 new Vector4(0.2554792f, 0.7445208f, 0.6167812f, t.y),
					 new Vector4(-0.6167812f, 0.6167812f, -0.4890417f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7445208f, 0.2554792f, 0.6167812f, t.x),
					 new Vector4(0.2554792f, 0.7445208f, -0.6167812f, t.y),
					 new Vector4(0.6167812f, -0.6167812f, -0.4890417f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v48_tCO(Vector3 t)
	{
		return new Matrix4x4[24] {
				 new Matrix4x4(
					 new Vector4(-0.3643623f, -0.8603695f, -0.3563767f, t.x),
					 new Vector4(-0.8603695f, 0.4574493f, -0.2247318f, t.y),
					 new Vector4(-0.3563767f, -0.2247318f, 0.906913f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.3643623f, -0.8603695f, 0.3563767f, t.x),
					 new Vector4(-0.8603695f, 0.4574493f, 0.2247318f, t.y),
					 new Vector4(0.3563767f, 0.2247318f, 0.906913f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.3643623f, 0.8603695f, -0.3563767f, t.x),
					 new Vector4(0.8603695f, 0.4574493f, 0.2247318f, t.y),
					 new Vector4(-0.3563767f, 0.2247318f, 0.906913f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.3643623f, 0.8603695f, 0.3563767f, t.x),
					 new Vector4(0.8603695f, 0.4574493f, -0.2247318f, t.y),
					 new Vector4(0.3563767f, -0.2247318f, 0.906913f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.3643623f, -0.3563767f, -0.8603695f, t.x),
					 new Vector4(-0.3563767f, 0.906913f, -0.2247318f, t.y),
					 new Vector4(-0.8603695f, -0.2247318f, 0.4574493f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.3643623f, -0.3563767f, 0.8603695f, t.x),
					 new Vector4(-0.3563767f, 0.906913f, 0.2247318f, t.y),
					 new Vector4(0.8603695f, 0.2247318f, 0.4574493f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.3643623f, 0.3563767f, -0.8603695f, t.x),
					 new Vector4(0.3563767f, 0.906913f, 0.2247318f, t.y),
					 new Vector4(-0.8603695f, 0.2247318f, 0.4574493f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.3643623f, 0.3563767f, 0.8603695f, t.x),
					 new Vector4(0.3563767f, 0.906913f, -0.2247318f, t.y),
					 new Vector4(0.8603695f, -0.2247318f, 0.4574493f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.4574493f, -0.8603695f, -0.2247318f, t.x),
					 new Vector4(-0.8603695f, -0.3643623f, -0.3563767f, t.y),
					 new Vector4(-0.2247318f, -0.3563767f, 0.906913f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.4574493f, -0.8603695f, 0.2247318f, t.x),
					 new Vector4(-0.8603695f, -0.3643623f, 0.3563767f, t.y),
					 new Vector4(0.2247318f, 0.3563767f, 0.906913f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.4574493f, 0.8603695f, -0.2247318f, t.x),
					 new Vector4(0.8603695f, -0.3643623f, 0.3563767f, t.y),
					 new Vector4(-0.2247318f, 0.3563767f, 0.906913f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.4574493f, 0.8603695f, 0.2247318f, t.x),
					 new Vector4(0.8603695f, -0.3643623f, -0.3563767f, t.y),
					 new Vector4(0.2247318f, -0.3563767f, 0.906913f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.906913f, -0.3563767f, -0.2247318f, t.x),
					 new Vector4(-0.3563767f, -0.3643623f, -0.8603695f, t.y),
					 new Vector4(-0.2247318f, -0.8603695f, 0.4574493f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.906913f, -0.3563767f, 0.2247318f, t.x),
					 new Vector4(-0.3563767f, -0.3643623f, 0.8603695f, t.y),
					 new Vector4(0.2247318f, 0.8603695f, 0.4574493f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.906913f, 0.3563767f, -0.2247318f, t.x),
					 new Vector4(0.3563767f, -0.3643623f, 0.8603695f, t.y),
					 new Vector4(-0.2247318f, 0.8603695f, 0.4574493f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.906913f, 0.3563767f, 0.2247318f, t.x),
					 new Vector4(0.3563767f, -0.3643623f, -0.8603695f, t.y),
					 new Vector4(0.2247318f, -0.8603695f, 0.4574493f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.4574493f, -0.2247318f, -0.8603695f, t.x),
					 new Vector4(-0.2247318f, 0.906913f, -0.3563767f, t.y),
					 new Vector4(-0.8603695f, -0.3563767f, -0.3643623f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.4574493f, -0.2247318f, 0.8603695f, t.x),
					 new Vector4(-0.2247318f, 0.906913f, 0.3563767f, t.y),
					 new Vector4(0.8603695f, 0.3563767f, -0.3643623f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.4574493f, 0.2247318f, -0.8603695f, t.x),
					 new Vector4(0.2247318f, 0.906913f, 0.3563767f, t.y),
					 new Vector4(-0.8603695f, 0.3563767f, -0.3643623f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.4574493f, 0.2247318f, 0.8603695f, t.x),
					 new Vector4(0.2247318f, 0.906913f, -0.3563767f, t.y),
					 new Vector4(0.8603695f, -0.3563767f, -0.3643623f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.906913f, -0.2247318f, -0.3563767f, t.x),
					 new Vector4(-0.2247318f, 0.4574493f, -0.8603695f, t.y),
					 new Vector4(-0.3563767f, -0.8603695f, -0.3643623f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.906913f, -0.2247318f, 0.3563767f, t.x),
					 new Vector4(-0.2247318f, 0.4574493f, 0.8603695f, t.y),
					 new Vector4(0.3563767f, 0.8603695f, -0.3643623f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.906913f, 0.2247318f, -0.3563767f, t.x),
					 new Vector4(0.2247318f, 0.4574493f, 0.8603695f, t.y),
					 new Vector4(-0.3563767f, 0.8603695f, -0.3643623f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.906913f, 0.2247318f, 0.3563767f, t.x),
					 new Vector4(0.2247318f, 0.4574493f, -0.8603695f, t.y),
					 new Vector4(0.3563767f, -0.8603695f, -0.3643623f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v12_tT(Vector3 t)
	{
		return new Matrix4x4[12] {
				 new Matrix4x4(
					 new Vector4(-0.6363636f, -0.5454546f, -0.5454546f, t.x),
					 new Vector4(-0.5454546f, 0.8181818f, -0.1818182f, t.y),
					 new Vector4(-0.5454546f, -0.1818182f, 0.8181818f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.6363636f, -0.5454546f, 0.5454546f, t.x),
					 new Vector4(-0.5454546f, 0.8181818f, 0.1818182f, t.y),
					 new Vector4(0.5454546f, 0.1818182f, 0.8181818f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.6363636f, 0.5454546f, -0.5454546f, t.x),
					 new Vector4(0.5454546f, 0.8181818f, 0.1818182f, t.y),
					 new Vector4(-0.5454546f, 0.1818182f, 0.8181818f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.6363636f, 0.5454546f, 0.5454546f, t.x),
					 new Vector4(0.5454546f, 0.8181818f, -0.1818182f, t.y),
					 new Vector4(0.5454546f, -0.1818182f, 0.8181818f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8181818f, -0.5454546f, -0.1818182f, t.x),
					 new Vector4(-0.5454546f, -0.6363636f, -0.5454546f, t.y),
					 new Vector4(-0.1818182f, -0.5454546f, 0.8181818f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8181818f, -0.5454546f, 0.1818182f, t.x),
					 new Vector4(-0.5454546f, -0.6363636f, 0.5454546f, t.y),
					 new Vector4(0.1818182f, 0.5454546f, 0.8181818f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8181818f, 0.5454546f, -0.1818182f, t.x),
					 new Vector4(0.5454546f, -0.6363636f, 0.5454546f, t.y),
					 new Vector4(-0.1818182f, 0.5454546f, 0.8181818f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8181818f, 0.5454546f, 0.1818182f, t.x),
					 new Vector4(0.5454546f, -0.6363636f, -0.5454546f, t.y),
					 new Vector4(0.1818182f, -0.5454546f, 0.8181818f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8181818f, -0.1818182f, -0.5454546f, t.x),
					 new Vector4(-0.1818182f, 0.8181818f, -0.5454546f, t.y),
					 new Vector4(-0.5454546f, -0.5454546f, -0.6363636f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8181818f, -0.1818182f, 0.5454546f, t.x),
					 new Vector4(-0.1818182f, 0.8181818f, 0.5454546f, t.y),
					 new Vector4(0.5454546f, 0.5454546f, -0.6363636f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8181818f, 0.1818182f, -0.5454546f, t.x),
					 new Vector4(0.1818182f, 0.8181818f, 0.5454546f, t.y),
					 new Vector4(-0.5454546f, 0.5454546f, -0.6363636f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8181818f, 0.1818182f, 0.5454546f, t.x),
					 new Vector4(0.1818182f, 0.8181818f, -0.5454546f, t.y),
					 new Vector4(0.5454546f, -0.5454546f, -0.6363636f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v12_I_G(Vector3 t)
	{
		return new Matrix4x4[6] {
				 new Matrix4x4(
					 new Vector4(0.4472136f, -0.8944272f, 0, t.x),
					 new Vector4(-0.8944272f, -0.4472136f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.4472136f, 0.8944272f, 0, t.x),
					 new Vector4(0.8944272f, -0.4472136f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.4472136f, 0, -0.8944272f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(-0.8944272f, 0, 0.4472136f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.4472136f, 0, 0.8944272f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0.8944272f, 0, 0.4472136f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 0.4472136f, -0.8944272f, t.y),
					 new Vector4(0, -0.8944272f, -0.4472136f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 0.4472136f, 0.8944272f, t.y),
					 new Vector4(0, 0.8944272f, -0.4472136f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v12_I_J(Vector3 t)
	{
		return new Matrix4x4[6] {
				 new Matrix4x4(
					 new Vector4(-0.4472136f, -0.8944272f, 0, t.x),
					 new Vector4(-0.8944272f, 0.4472136f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.4472136f, 0.8944272f, 0, t.x),
					 new Vector4(0.8944272f, 0.4472136f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.4472136f, 0, -0.8944272f, t.x),
					 new Vector4(0, 1, 0f, t.y),
					 new Vector4(-0.8944272f, 0, -0.4472136f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.4472136f, 0, 0.8944272f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0.8944272f, 0, -0.4472136f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -0.4472136f, -0.8944272f, t.y),
					 new Vector4(0, -0.8944272f, 0.4472136f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -0.4472136f, 0.8944272f, t.y),
					 new Vector4(0, 0.8944272f, 0.4472136f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v20_D_G(Vector3 t)
	{
		return new Matrix4x4[10] {
				 new Matrix4x4(
					 new Vector4(-0.745356f, -0.6666667f, 0, t.x),
					 new Vector4(-0.6666667f, 0.745356f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.745356f, 0.6666667f, 0, t.x),
					 new Vector4(0.6666667f, 0.745356f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.745356f, 0, -0.6666667f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(-0.6666667f, 0, -0.745356f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.745356f, 0, 0.6666667f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0.6666667f, 0, -0.745356f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -0.745356f, -0.6666667f, t.y),
					 new Vector4(0, -0.6666667f, 0.745356f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -0.745356f, 0.6666667f, t.y),
					 new Vector4(0, 0.6666667f, 0.745356f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3333333f, -0.6666667f, -0.6666667f, t.x),
					 new Vector4(-0.6666667f, 0.3333333f, -0.6666667f, t.y),
					 new Vector4(-0.6666667f, -0.6666667f, 0.3333333f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3333333f, -0.6666667f, 0.6666667f, t.x),
					 new Vector4(-0.6666667f, 0.3333333f, 0.6666667f, t.y),
					 new Vector4(0.6666667f, 0.6666667f, 0.3333333f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3333333f, 0.6666667f, -0.6666667f, t.x),
					 new Vector4(0.6666667f, 0.3333333f, 0.6666667f, t.y),
					 new Vector4(-0.6666667f, 0.6666667f, 0.3333333f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3333333f, 0.6666667f, 0.6666667f, t.x),
					 new Vector4(0.6666667f, 0.3333333f, -0.6666667f, t.y),
					 new Vector4(0.6666667f, -0.6666667f, 0.3333333f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v20_D_J(Vector3 t)
	{
		return new Matrix4x4[10] {
				 new Matrix4x4(
					 new Vector4(0.745356f, -0.6666667f, 0, t.x),
					 new Vector4(-0.6666667f, -0.745356f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.745356f, 0.6666667f, 0, t.x),
					 new Vector4(0.6666667f, -0.745356f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.745356f, 0, -0.6666667f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(-0.6666667f, 0, 0.745356f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.745356f, 0, 0.6666667f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0.6666667f, 0, 0.745356f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 0.745356f, -0.6666667f, t.y),
					 new Vector4(0, -0.6666667f, -0.745356f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 0.745356f, 0.6666667f, t.y),
					 new Vector4(0, 0.6666667f, -0.745356f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3333333f, -0.6666667f, -0.6666667f, t.x),
					 new Vector4(-0.6666667f, 0.3333333f, -0.6666667f, t.y),
					 new Vector4(-0.6666667f, -0.6666667f, 0.3333333f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3333333f, -0.6666667f, 0.6666667f, t.x),
					 new Vector4(-0.6666667f, 0.3333333f, 0.6666667f, t.y),
					 new Vector4(0.6666667f, 0.6666667f, 0.3333333f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3333333f, 0.6666667f, -0.6666667f, t.x),
					 new Vector4(0.6666667f, 0.3333333f, 0.6666667f, t.y),
					 new Vector4(-0.6666667f, 0.6666667f, 0.3333333f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3333333f, 0.6666667f, 0.6666667f, t.x),
					 new Vector4(0.6666667f, 0.3333333f, -0.6666667f, t.y),
					 new Vector4(0.6666667f, -0.6666667f, 0.3333333f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v30_ID_G(Vector3 t)
	{
		return new Matrix4x4[15] {
				 new Matrix4x4(
					 new Vector4(-1, 0, 0, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -1, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0, 0, -1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.309017f, -0.809017f, -0.5f, t.x),
					 new Vector4(-0.809017f, 0.5f, -0.309017f, t.y),
					 new Vector4(-0.5f, -0.309017f, 0.809017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.309017f, -0.809017f, 0.5f, t.x),
					 new Vector4(-0.809017f, 0.5f, 0.309017f, t.y),
					 new Vector4(0.5f, 0.309017f, 0.809017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.309017f, 0.809017f, -0.5f, t.x),
					 new Vector4(0.809017f, 0.5f, 0.309017f, t.y),
					 new Vector4(-0.5f, 0.309017f, 0.809017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.309017f, 0.809017f, 0.5f, t.x),
					 new Vector4(0.809017f, 0.5f, -0.309017f, t.y),
					 new Vector4(0.5f, -0.309017f, 0.809017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.5f, -0.309017f, -0.809017f, t.x),
					 new Vector4(-0.309017f, 0.809017f, -0.5f, t.y),
					 new Vector4(-0.809017f, -0.5f, -0.309017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.5f, -0.309017f, 0.809017f, t.x),
					 new Vector4(-0.309017f, 0.809017f, 0.5f, t.y),
					 new Vector4(0.809017f, 0.5f, -0.309017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.5f, 0.309017f, -0.809017f, t.x),
					 new Vector4(0.309017f, 0.809017f, 0.5f, t.y),
					 new Vector4(-0.809017f, 0.5f, -0.309017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.5f, 0.309017f, 0.809017f, t.x),
					 new Vector4(0.309017f, 0.809017f, -0.5f, t.y),
					 new Vector4(0.809017f, -0.5f, -0.309017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.809017f, -0.5f, -0.309017f, t.x),
					 new Vector4(-0.5f, -0.309017f, -0.809017f, t.y),
					 new Vector4(-0.309017f, -0.809017f, 0.5f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.809017f, -0.5f, 0.309017f, t.x),
					 new Vector4(-0.5f, -0.309017f, 0.809017f, t.y),
					 new Vector4(0.309017f, 0.809017f, 0.5f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.809017f, 0.5f, -0.309017f, t.x),
					 new Vector4(0.5f, -0.309017f, 0.809017f, t.y),
					 new Vector4(-0.309017f, 0.809017f, 0.5f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.809017f, 0.5f, 0.309017f, t.x),
					 new Vector4(0.5f, -0.309017f, -0.809017f, t.y),
					 new Vector4(0.309017f, -0.809017f, 0.5f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v30_ID_J(Vector3 t)
	{
		return new Matrix4x4[15] {
				 new Matrix4x4(
					 new Vector4(-1, 0, 0, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -1, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0, 0, -1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.309017f, -0.5f, -0.809017f, t.x),
					 new Vector4(-0.5f, 0.809017f, -0.309017f, t.y),
					 new Vector4(-0.809017f, -0.309017f, 0.5f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.309017f, -0.5f, 0.809017f, t.x),
					 new Vector4(-0.5f, 0.809017f, 0.309017f, t.y),
					 new Vector4(0.809017f, 0.309017f, 0.5f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.309017f, 0.5f, -0.809017f, t.x),
					 new Vector4(0.5f, 0.809017f, 0.309017f, t.y),
					 new Vector4(-0.809017f, 0.309017f, 0.5f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.309017f, 0.5f, 0.809017f, t.x),
					 new Vector4(0.5f, 0.809017f, -0.309017f, t.y),
					 new Vector4(0.809017f, -0.309017f, 0.5f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.809017f, -0.309017f, -0.5f, t.x),
					 new Vector4(-0.309017f, 0.5f, -0.809017f, t.y),
					 new Vector4(-0.5f, -0.809017f, -0.309017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.809017f, -0.309017f, 0.5f, t.x),
					 new Vector4(-0.309017f, 0.5f, 0.809017f, t.y),
					 new Vector4(0.5f, 0.809017f, -0.309017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.809017f, 0.309017f, -0.5f, t.x),
					 new Vector4(0.309017f, 0.5f, 0.809017f, t.y),
					 new Vector4(-0.5f, 0.809017f, -0.309017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.809017f, 0.309017f, 0.5f, t.x),
					 new Vector4(0.309017f, 0.5f, -0.809017f, t.y),
					 new Vector4(0.5f, -0.809017f, -0.309017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.5f, -0.809017f, -0.309017f, t.x),
					 new Vector4(-0.809017f, -0.309017f, -0.5f, t.y),
					 new Vector4(-0.309017f, -0.5f, 0.809017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.5f, -0.809017f, 0.309017f, t.x),
					 new Vector4(-0.809017f, -0.309017f, 0.5f, t.y),
					 new Vector4(0.309017f, 0.5f, 0.809017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.5f, 0.809017f, -0.309017f, t.x),
					 new Vector4(0.809017f, -0.309017f, 0.5f, t.y),
					 new Vector4(-0.309017f, 0.5f, 0.809017f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.5f, 0.809017f, 0.309017f, t.x),
					 new Vector4(0.809017f, -0.309017f, -0.5f, t.y),
					 new Vector4(0.309017f, -0.5f, 0.809017f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v60_tI_G(Vector3 t)
	{
		return new Matrix4x4[30] {
				 new Matrix4x4(
					 new Vector4(-0.9185744f, -0.197624f, 0, t.x),
					 new Vector4(-0.197624f, 0.9592872f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.9185744f, 0.197624f, 0, t.x),
					 new Vector4(0.197624f, 0.9592872f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9592872f, 0, -0.197624f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(-0.197624f, 0, -0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9592872f, 0, 0.197624f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0.197624f, 0, -0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -0.9185744f, -0.197624f, t.y),
					 new Vector4(0, -0.197624f, 0.9592872f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -0.9185744f, 0.197624f, t.y),
					 new Vector4(0, 0.197624f, 0.9592872f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.06587468f, -0.1473003f, -0.4766736f, t.x),
					 new Vector4(-0.1473003f, 0.9185744f, -0.1317494f, t.y),
					 new Vector4(-0.4766736f, -0.1317494f, 0.1473003f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.06587468f, -0.1473003f, 0.4766736f, t.x),
					 new Vector4(-0.1473003f, 0.9185744f, 0.1317494f, t.y),
					 new Vector4(0.4766736f, 0.1317494f, 0.1473003f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.06587468f, 0.1473003f, -0.4766736f, t.x),
					 new Vector4(0.1473003f, 0.9185744f, 0.1317494f, t.y),
					 new Vector4(-0.4766736f, 0.1317494f, 0.1473003f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.06587468f, 0.1473003f, 0.4766736f, t.x),
					 new Vector4(0.1473003f, 0.9185744f, -0.1317494f, t.y),
					 new Vector4(0.4766736f, -0.1317494f, 0.1473003f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.1473003f, -0.4766736f, -0.1317494f, t.x),
					 new Vector4(-0.4766736f, -0.06587468f, -0.1473003f, t.y),
					 new Vector4(-0.1317494f, -0.1473003f, 0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.1473003f, -0.4766736f, 0.1317494f, t.x),
					 new Vector4(-0.4766736f, -0.06587468f, 0.1473003f, t.y),
					 new Vector4(0.1317494f, 0.1473003f, 0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.1473003f, 0.4766736f, -0.1317494f, t.x),
					 new Vector4(0.4766736f, -0.06587468f, 0.1473003f, t.y),
					 new Vector4(-0.1317494f, 0.1473003f, 0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.1473003f, 0.4766736f, 0.1317494f, t.x),
					 new Vector4(0.4766736f, -0.06587468f, -0.1473003f, t.y),
					 new Vector4(0.1317494f, -0.1473003f, 0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9185744f, -0.1317494f, -0.1473003f, t.x),
					 new Vector4(-0.1317494f, 0.1473003f, -0.4766736f, t.y),
					 new Vector4(-0.1473003f, -0.4766736f, -0.06587468f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9185744f, -0.1317494f, 0.1473003f, t.x),
					 new Vector4(-0.1317494f, 0.1473003f, 0.4766736f, t.y),
					 new Vector4(0.1473003f, 0.4766736f, -0.06587468f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9185744f, 0.1317494f, -0.1473003f, t.x),
					 new Vector4(0.1317494f, 0.1473003f, 0.4766736f, t.y),
					 new Vector4(-0.1473003f, 0.4766736f, -0.06587468f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9185744f, 0.1317494f, 0.1473003f, t.x),
					 new Vector4(0.1317494f, 0.1473003f, -0.4766736f, t.y),
					 new Vector4(0.1473003f, -0.4766736f, -0.06587468f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.188013f, -0.1724622f, -0.1395248f, t.x),
					 new Vector4(-0.1724622f, 0.6742977f, -0.08623108f, t.y),
					 new Vector4(-0.1395248f, -0.08623108f, 0.7868251f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.188013f, -0.1724622f, 0.1395248f, t.x),
					 new Vector4(-0.1724622f, 0.6742977f, 0.08623108f, t.y),
					 new Vector4(0.1395248f, -0.08623108f, 0.7868251f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.188013f, 0.1724622f, -0.1395248f, t.x),
					 new Vector4(0.1724622f, 0.6742977f, 0.08623108f, t.y),
					 new Vector4(-0.1395248f, 0.08623108f, 0.7868251f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.188013f, 0.1724622f, 0.1395248f, t.x),
					 new Vector4(0.1724622f, 0.6742977f, -0.08623108f, t.y),
					 new Vector4(0.1395248f, -0.08623108f, 0.7868251f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7868251f, -0.1395248f, -0.08623108f, t.x),
					 new Vector4(-0.1395248f, -0.188013f, -0.1724622f, t.y),
					 new Vector4(-0.08623108f, -0.1724622f, 0.6742977f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7868251f, -0.1395248f, 0.08623108f, t.x),
					 new Vector4(-0.1395248f, -0.188013f, 0.1724622f, t.y),
					 new Vector4(0.08623108f, 0.1724622f, 0.6742977f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7868251f, 0.1395248f, -0.08623108f, t.x),
					 new Vector4(0.1395248f, -0.188013f, 0.1724622f, t.y),
					 new Vector4(-0.08623108f, 0.1724622f, 0.6742977f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7868251f, 0.1395248f, 0.08623108f, t.x),
					 new Vector4(0.1395248f, -0.188013f, -0.1724622f, t.y),
					 new Vector4(0.08623108f, -0.1724622f, 0.6742977f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6742977f, -0.08623108f, -0.1724622f, t.x),
					 new Vector4(-0.08623108f, 0.7868251f, -0.1395248f, t.y),
					 new Vector4(-0.1724622f, -0.1395248f, -0.188013f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6742977f, -0.08623108f, 0.1724622f, t.x),
					 new Vector4(-0.08623108f, 0.7868251f, 0.1395248f, t.y),
					 new Vector4(0.1724622f, 0.1395248f, -0.188013f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6742977f, 0.08623108f, -0.1724622f, t.x),
					 new Vector4(0.08623108f, 0.7868251f, 0.1395248f, t.y),
					 new Vector4(-0.1724622f, 0.1395248f, -0.188013f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6742977f, 0.08623108f, 0.1724622f, t.x),
					 new Vector4(0.08623108f, 0.7868251f, -0.1395248f, t.y),
					 new Vector4(0.1724622f, -0.1395248f, -0.188013f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v60_tI_J(Vector3 t)
	{
		return new Matrix4x4[30] {
				 new Matrix4x4(
					 new Vector4(0.9185744f, -0.197624f, 0, t.x),
					 new Vector4(-0.197624f, -0.9592872f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9185744f, 0.197624f, 0, t.x),
					 new Vector4(0.197624f, -0.9592872f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.9592872f, 0, -0.197624f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(-0.197624f, 0, 0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.9592872f, 0, 0.197624f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0.197624f, 0, 0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 0.9185744f, -0.197624f, t.y),
					 new Vector4(0, -0.197624f, -0.9592872f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 0.9185744f, 0.197624f, t.y),
					 new Vector4(0, 0.197624f, -0.9592872f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.06587468f, -0.4766736f, -0.1473003f, t.x),
					 new Vector4(-0.4766736f, 0.1473003f, -0.1317494f, t.y),
					 new Vector4(-0.1473003f, -0.1317494f, 0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.06587468f, 0.4766736f, -0.1473003f, t.x),
					 new Vector4(0.4766736f, 0.1473003f, 0.1317494f, t.y),
					 new Vector4(-0.1473003f, 0.1317494f, 0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.06587468f, 0.4766736f, -0.1473003f, t.x),
					 new Vector4(0.4766736f, 0.1473003f, 0.1317494f, t.y),
					 new Vector4(-0.1473003f, 0.1317494f, 0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.06587468f, 0.4766736f, 0.1473003f, t.x),
					 new Vector4(0.4766736f, 0.1473003f, -0.1317494f, t.y),
					 new Vector4(0.1473003f, -0.1317494f, 0.9185744f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9185744f, -0.1473003f, -0.1317494f, t.x),
					 new Vector4(-0.1473003f, -0.06587468f, -0.4766736f, t.y),
					 new Vector4(-0.1317494f, -0.4766736f, 0.1473003f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9185744f, -0.1473003f, 0.1317494f, t.x),
					 new Vector4(-0.1473003f, -0.06587468f, 0.4766736f, t.y),
					 new Vector4(0.1317494f, 0.4766736f, 0.1473003f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9185744f, 0.1473003f, -0.1317494f, t.x),
					 new Vector4(0.1473003f, -0.06587468f, 0.4766736f, t.y),
					 new Vector4(-0.1317494f, 0.4766736f, 0.1473003f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9185744f, 0.1473003f, 0.1317494f, t.x),
					 new Vector4(0.1473003f, -0.06587468f, -0.4766736f, t.y),
					 new Vector4(0.1317494f, -0.4766736f, 0.1473003f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.1473003f, -0.1317494f, -0.4766736f, t.x),
					 new Vector4(-0.1317494f, 0.9185744f, -0.1473003f, t.y),
					 new Vector4(-0.4766736f, -0.1473003f, -0.06587468f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.1473003f, -0.1317494f, 0.4766736f, t.x),
					 new Vector4(-0.1317494f, 0.9185744f, 0.1473003f, t.y),
					 new Vector4(0.4766736f, 0.1473003f, -0.06587468f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.1473003f, 0.1317494f, -0.4766736f, t.x),
					 new Vector4(0.1317494f, 0.9185744f, 0.1473003f, t.y),
					 new Vector4(-0.4766736f, 0.1473003f, -0.06587468f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.1473003f, 0.1317494f, 0.4766736f, t.x),
					 new Vector4(0.1317494f, 0.9185744f, -0.1473003f, t.y),
					 new Vector4(0.4766736f, -0.1473003f, -0.06587468f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.188013f, -0.1395248f, -0.1724622f, t.x),
					 new Vector4(-0.1395248f, 0.7868251f, -0.08623108f, t.y),
					 new Vector4(-0.1724622f, -0.08623108f, 0.6742977f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.188013f, -0.1395248f, 0.1724622f, t.x),
					 new Vector4(-0.1395248f, 0.7868251f, 0.08623108f, t.y),
					 new Vector4(0.1724622f, 0.08623108f, 0.6742977f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.188013f, 0.1395248f, -0.1724622f, t.x),
					 new Vector4(0.1395248f, 0.7868251f, 0.08623108f, t.y),
					 new Vector4(-0.1724622f, 0.08623108f, 0.6742977f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.188013f, 0.1395248f, 0.1724622f, t.x),
					 new Vector4(0.1395248f, 0.7868251f, -0.08623108f, t.y),
					 new Vector4(0.1724622f, -0.08623108f, 0.6742977f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6742977f, -0.1724622f, -0.08623108f, t.x),
					 new Vector4(-0.1724622f, -0.188013f, -0.1395248f, t.y),
					 new Vector4(-0.08623108f, -0.1395248f, 0.7868251f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6742977f, -0.1724622f, 0.08623108f, t.x),
					 new Vector4(-0.1724622f, -0.188013f, 0.1395248f, t.y),
					 new Vector4(0.08623108f, 0.1395248f, 0.7868251f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6742977f, 0.1724622f, -0.08623108f, t.x),
					 new Vector4(0.1724622f, -0.188013f, 0.1395248f, t.y),
					 new Vector4(-0.08623108f, 0.1395248f, 0.7868251f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6742977f, 0.1724622f, 0.08623108f, t.x),
					 new Vector4(0.1724622f, -0.188013f, -0.1395248f, t.y),
					 new Vector4(0.08623108f, -0.1395248f, 0.7868251f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7868251f, -0.08623108f, -0.1395248f, t.x),
					 new Vector4(-0.08623108f, 0.6742977f, -0.1724622f, t.y),
					 new Vector4(-0.1395248f, -0.1724622f, -0.188013f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7868251f, -0.08623108f, 0.1395248f, t.x),
					 new Vector4(-0.08623108f, 0.6742977f, 0.1724622f, t.y),
					 new Vector4(0.1395248f, 0.1724622f, -0.188013f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7868251f, 0.08623108f, -0.1395248f, t.x),
					 new Vector4(0.08623108f, 0.6742977f, 0.1724622f, t.y),
					 new Vector4(-0.1395248f, 0.1724622f, -0.188013f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7868251f, 0.08623108f, 0.1395248f, t.x),
					 new Vector4(0.08623108f, 0.6742977f, -0.1724622f, t.y),
					 new Vector4(0.1395248f, -0.1724622f, -0.188013f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v60_tD_G(Vector3 t)
	{
		return new Matrix4x4[30] {
				 new Matrix4x4(
					 new Vector4(-0.9432954f, -0.08298862f, 0, t.x),
					 new Vector4(-0.08298862f, 0.9432954f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.9432954f, 0.08298862f, 0, t.x),
					 new Vector4(0.08298862f, 0.9432954f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9432954f, 0, -0.08298862f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(-0.08298862f, 0, -0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9432954f, 0, 0.08298862f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0.08298862f, 0, -0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -0.9432954f, -0.08298862f, t.y),
					 new Vector4(0, -0.08298862f, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -0.9432954f, 0.08298862f, t.y),
					 new Vector4(0, 0.08298862f, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.5546363f, -0.07422728f, -0.1943295f, t.x),
					 new Vector4(-0.07422728f, 0.9432954f, -0.03711364f, t.y),
					 new Vector4(-0.1943295f, -0.03711364f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.5546363f, -0.07422728f, 0.1943295f, t.x),
					 new Vector4(-0.07422728f, 0.9432954f, 0.03711364f, t.y),
					 new Vector4(0.1943295f, 0.03711364f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.5546363f, 0.07422728f, -0.1943295f, t.x),
					 new Vector4(0.07422728f, 0.9432954f, 0.03711364f, t.y),
					 new Vector4(-0.1943295f, 0.03711364f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.5546363f, 0.07422728f, 0.1943295f, t.x),
					 new Vector4(0.07422728f, 0.9432954f, -0.03711364f, t.y),
					 new Vector4(0.1943295f, -0.03711364f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, -0.1943295f, -0.03711364f, t.x),
					 new Vector4(-0.1943295f, -0.5546363f, -0.07422728f, t.y),
					 new Vector4(-0.03711364f, -0.07422728f, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, -0.1943295f, 0.03711364f, t.x),
					 new Vector4(-0.1943295f, -0.5546363f, 0.07422728f, t.y),
					 new Vector4(0.03711364f, 0.07422728f, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, 0.1943295f, -0.03711364f, t.x),
					 new Vector4(0.1943295f, -0.5546363f, 0.07422728f, t.y),
					 new Vector4(-0.03711364f, 0.07422728f, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, 0.1943295f, 0.03711364f, t.x),
					 new Vector4(0.1943295f, -0.5546363f, -0.07422728f, t.y),
					 new Vector4(0.03711364f, -0.07422728f, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9432954f, -0.03711364f, -0.07422728f, t.x),
					 new Vector4(-0.03711364f, 0.6113409f, -0.1943295f, t.y),
					 new Vector4(-0.07422728f, -0.1943295f, -0.5546363f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9432954f, -0.03711364f, 0.07422728f, t.x),
					 new Vector4(-0.03711364f, 0.6113409f, 0.1943295f, t.y),
					 new Vector4(0.07422728f, 0.1943295f, -0.5546363f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9432954f, 0.03711364f, -0.07422728f, t.x),
					 new Vector4(0.03711364f, 0.6113409f, 0.1943295f, t.y),
					 new Vector4(-0.07422728f, 0.1943295f, -0.5546363f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9432954f, 0.03711364f, 0.07422728f, t.x),
					 new Vector4(0.03711364f, 0.6113409f, -0.1943295f, t.y),
					 new Vector4(0.07422728f, -0.1943295f, -0.5546363f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.01752268f, -0.1572159f, -0.1943295f, t.x),
					 new Vector4(-0.1572159f, 0.6113409f, -0.1201023f, t.y),
					 new Vector4(-0.1943295f, -0.1201023f, 0.7030909f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.01752268f, -0.1572159f, 0.1943295f, t.x),
					 new Vector4(-0.1572159f, 0.6113409f, 0.1201023f, t.y),
					 new Vector4(0.1943295f, 0.1201023f, 0.7030909f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.01752268f, 0.1572159f, -0.1943295f, t.x),
					 new Vector4(0.1572159f, 0.6113409f, 0.1201023f, t.y),
					 new Vector4(-0.1943295f, 0.1201023f, 0.7030909f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.01752268f, 0.1572159f, 0.1943295f, t.x),
					 new Vector4(0.1572159f, 0.6113409f, -0.1201023f, t.y),
					 new Vector4(0.1943295f, -0.1201023f, 0.7030909f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7030909f, -0.1943295f, -0.1201023f, t.x),
					 new Vector4(-0.1943295f, -0.01752268f, -0.1572159f, t.y),
					 new Vector4(-0.1201023f, -0.1572159f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7030909f, -0.1943295f, 0.1201023f, t.x),
					 new Vector4(-0.1943295f, -0.01752268f, 0.1572159f, t.y),
					 new Vector4(0.1201023f, 0.1572159f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7030909f, 0.1943295f, -0.1201023f, t.x),
					 new Vector4(0.1943295f, -0.01752268f, 0.1572159f, t.y),
					 new Vector4(-0.1201023f, 0.1572159f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7030909f, 0.1943295f, 0.1201023f, t.x),
					 new Vector4(0.1943295f, -0.01752268f, -0.1572159f, t.y),
					 new Vector4(0.1201023f, -0.1572159f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, -0.1201023f, -0.1572159f, t.x),
					 new Vector4(-0.1201023f, 0.7030909f, -0.1943295f, t.y),
					 new Vector4(-0.1572159f, -0.1943295f, -0.01752268f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, -0.1201023f, 0.1572159f, t.x),
					 new Vector4(-0.1201023f, 0.7030909f, 0.1943295f, t.y),
					 new Vector4(0.1572159f, 0.1943295f, -0.01752268f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, 0.1201023f, -0.1572159f, t.x),
					 new Vector4(0.1201023f, 0.7030909f, 0.1943295f, t.y),
					 new Vector4(-0.1572159f, 0.1943295f, -0.01752268f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, 0.1201023f, 0.1572159f, t.x),
					 new Vector4(0.1201023f, 0.7030909f, -0.1943295f, t.y),
					 new Vector4(0.1572159f, -0.1943295f, -0.01752268f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v60_tD_J(Vector3 t)
	{
		return new Matrix4x4[30] {
				 new Matrix4x4(
					 new Vector4(0.9432954f, -0.08298862f, 0, t.x),
					 new Vector4(-0.08298862f, -0.9432954f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9432954f, 0.08298862f, 0, t.x),
					 new Vector4(0.08298862f, -0.9432954f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.9432954f, 0, -0.08298862f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(-0.08298862f, 0, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.9432954f, 0, 0.08298862f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0.08298862f, 0, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1f, 0f, 0f, t.x),
					 new Vector4(0f, 0.9432954f, -0.08298862f, t.y),
					 new Vector4(0f, -0.08298862f, -0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 0.9432954f, 0.08298862f, t.y),
					 new Vector4(0, 0.08298862f, -0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.5546363f, -0.1943295f, -0.07422728f, t.x),
					 new Vector4(-0.1943295f, 0.6113409f, -0.03711364f, t.y),
					 new Vector4(-0.07422728f, -0.03711364f, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.5546363f, -0.1943295f, 0.07422728f, t.x),
					 new Vector4(-0.1943295f, 0.6113409f, 0.03711364f, t.y),
					 new Vector4(0.07422728f, 0.03711364f, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.5546363f, 0.1943295f, -0.07422728f, t.x),
					 new Vector4(0.1943295f, 0.6113409f, 0.03711364f, t.y),
					 new Vector4(-0.07422728f, 0.03711364f, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.5546363f, 0.1943295f, 0.07422728f, t.x),
					 new Vector4(0.1943295f, 0.6113409f, -0.03711364f, t.y),
					 new Vector4(0.07422728f, -0.03711364f, 0.9432954f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9432954f, -0.07422728f, -0.03711364f, t.x),
					 new Vector4(-0.07422728f, -0.5546363f, -0.1943295f, t.y),
					 new Vector4(-0.03711364f, -0.1943295f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9432954f, -0.07422728f, 0.03711364f, t.x),
					 new Vector4(-0.07422728f, -0.5546363f, 0.1943295f, t.y),
					 new Vector4(0.03711364f, 0.1943295f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9432954f, 0.07422728f, -0.03711364f, t.x),
					 new Vector4(0.07422728f, -0.5546363f, 0.1943295f, t.y),
					 new Vector4(-0.03711364f, 0.1943295f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.9432954f, 0.07422728f, 0.03711364f, t.x),
					 new Vector4(0.07422728f, -0.5546363f, -0.1943295f, t.y),
					 new Vector4(0.03711364f, -0.1943295f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, -0.03711364f, -0.1943295f, t.x),
					 new Vector4(-0.03711364f, 0.9432954f, -0.07422728f, t.y),
					 new Vector4(-0.1943295f, -0.07422728f, -0.5546363f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, -0.03711364f, 0.1943295f, t.x),
					 new Vector4(-0.03711364f, 0.9432954f, 0.07422728f, t.y),
					 new Vector4(0.1943295f, 0.07422728f, -0.5546363f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, 0.03711364f, -0.1943295f, t.x),
					 new Vector4(0.03711364f, 0.9432954f, 0.07422728f, t.y),
					 new Vector4(-0.1943295f, 0.07422728f, -0.5546363f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, 0.03711364f, 0.1943295f, t.x),
					 new Vector4(0.03711364f, 0.9432954f, -0.07422728f, t.y),
					 new Vector4(0.1943295f, -0.07422728f, -0.5546363f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.01752268f, -0.1943295f, -0.1572159f, t.x),
					 new Vector4(-0.1943295f, 0.7030909f, -0.1201023f, t.y),
					 new Vector4(-0.1572159f, -0.1201023f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.01752268f, -0.1943295f, 0.1572159f, t.x),
					 new Vector4(-0.1943295f, 0.7030909f, 0.1201023f, t.y),
					 new Vector4(0.1572159f, 0.1201023f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.01752268f, 0.1943295f, -0.1572159f, t.x),
					 new Vector4(0.1943295f, 0.7030909f, 0.1201023f, t.y),
					 new Vector4(-0.1572159f, 0.1201023f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.01752268f, 0.1943295f, 0.1572159f, t.x),
					 new Vector4(0.1943295f, 0.7030909f, -0.1201023f, t.y),
					 new Vector4(0.1572159f, -0.1201023f, 0.6113409f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, -0.1572159f, -0.1201023f, t.x),
					 new Vector4(-0.1572159f, -0.01752268f, -0.1943295f, t.y),
					 new Vector4(-0.1201023f, -0.1943295f, 0.7030909f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, -0.1572159f, 0.1201023f, t.x),
					 new Vector4(-0.1572159f, -0.01752268f, 0.1943295f, t.y),
					 new Vector4(0.1201023f, 0.1943295f, 0.7030909f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, 0.1572159f, -0.1201023f, t.x),
					 new Vector4(0.1572159f, -0.01752268f, 0.1943295f, t.y),
					 new Vector4(-0.1201023f, 0.1943295f, 0.7030909f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.6113409f, 0.1572159f, 0.1201023f, t.x),
					 new Vector4(0.1572159f, -0.01752268f, -0.1943295f, t.y),
					 new Vector4(0.1201023f, -0.1943295f, 0.7030909f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7030909f, -0.1201023f, -0.1943295f, t.x),
					 new Vector4(-0.1201023f, 0.6113409f, -0.1572159f, t.y),
					 new Vector4(-0.1943295f, -0.1572159f, -0.01752268f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7030909f, -0.1201023f, 0.1943295f, t.x),
					 new Vector4(-0.1201023f, 0.6113409f, 0.1572159f, t.y),
					 new Vector4(0.1943295f, 0.1572159f, -0.01752268f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7030909f, 0.1201023f, -0.1943295f, t.x),
					 new Vector4(0.1201023f, 0.6113409f, 0.1572159f, t.y),
					 new Vector4(-0.1943295f, 0.1572159f, -0.01752268f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7030909f, 0.1201023f, 0.1943295f, t.x),
					 new Vector4(0.1201023f, 0.6113409f, -0.1572159f, t.y),
					 new Vector4(0.1943295f, -0.1572159f, -0.01752268f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v60_rID_G(Vector3 t)
	{
		return new Matrix4x4[30] {
				 new Matrix4x4(
					 new Vector4(-0.7994412f, -0.4247904f, -0.4247904f, t.x),
					 new Vector4(-0.4247904f, 0.8997206f, -0.1002794f, t.y),
					 new Vector4(-0.4247904f, -0.1002794f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.7994412f, -0.4247904f, 0.4247904f, t.x),
					 new Vector4(-0.4247904f, 0.8997206f, 0.1002794f, t.y),
					 new Vector4(0.4247904f, 0.1002794f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.7994412f, 0.4247904f, -0.4247904f, t.x),
					 new Vector4(0.4247904f, 0.8997206f, 0.1002794f, t.y),
					 new Vector4(-0.4247904f, 0.1002794f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.7994412f, 0.4247904f, 0.4247904f, t.x),
					 new Vector4(0.4247904f, 0.8997206f, -0.1002794f, t.y),
					 new Vector4(0.4247904f, -0.1002794f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, -0.4247904f, -0.1002794f, t.x),
					 new Vector4(-0.4247904f, -0.7994412f, -0.4247904f, t.y),
					 new Vector4(-0.1002794f, -0.4247904f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, -0.4247904f, 0.1002794f, t.x),
					 new Vector4(-0.4247904f, -0.7994412f, 0.4247904f, t.y),
					 new Vector4(0.1002794f, 0.4247904f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, 0.4247904f, -0.1002794f, t.x),
					 new Vector4(0.4247904f, -0.7994412f, 0.4247904f, t.y),
					 new Vector4(-0.1002794f, 0.4247904f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, 0.4247904f, 0.1002794f, t.x),
					 new Vector4(0.4247904f, -0.7994412f, -0.4247904f, t.y),
					 new Vector4(0.1002794f, -0.4247904f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, -0.1002794f, -0.4247904f, t.x),
					 new Vector4(-0.1002794f, 0.8997206f, -0.4247904f, t.y),
					 new Vector4(-0.4247904f, -0.4247904f, -0.7994412f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, -0.1002794f, 0.4247904f, t.x),
					 new Vector4(-0.1002794f, 0.8997206f, 0.4247904f, t.y),
					 new Vector4(0.4247904f, 0.4247904f, -0.7994412f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, 0.1002794f, -0.4247904f, t.x),
					 new Vector4(0.1002794f, 0.8997206f, 0.4247904f, t.y),
					 new Vector4(-0.4247904f, 0.4247904f, -0.7994412f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, 0.1002794f, 0.4247904f, t.x),
					 new Vector4(0.1002794f, 0.8997206f, -0.4247904f, t.y),
					 new Vector4(0.4247904f, -0.4247904f, -0.7994412f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.05013971f, -0.8495809f, -0.5250698f, t.x),
					 new Vector4(-0.8495809f, 0.3126746f, -0.4247904f, t.y),
					 new Vector4(-0.5250698f, -0.4247904f, 0.7374651f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.05013971f, -0.8495809f, 0.5250698f, t.x),
					 new Vector4(-0.8495809f, 0.3126746f, 0.4247904f, t.y),
					 new Vector4(0.5250698f, 0.4247904f, 0.7374651f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.05013971f, 0.8495809f, -0.5250698f, t.x),
					 new Vector4(0.8495809f, 0.3126746f, 0.4247904f, t.y),
					 new Vector4(-0.5250698f, 0.4247904f, 0.7374651f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.05013971f, 0.8495809f, 0.5250698f, t.x),
					 new Vector4(0.8495809f, 0.3126746f, -0.4247904f, t.y),
					 new Vector4(0.5250698f, -0.4247904f, 0.7374651f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7374651f, -0.5250698f, -0.4247904f, t.x),
					 new Vector4(-0.5250698f, -0.05013971f, -0.8495809f, t.y),
					 new Vector4(-0.4247904f, -0.8495809f, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7374651f, -0.5250698f, 0.4247904f, t.x),
					 new Vector4(-0.5250698f, -0.05013971f, 0.8495809f, t.y),
					 new Vector4(0.4247904f, 0.8495809f, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7374651f, 0.5250698f, -0.4247904f, t.x),
					 new Vector4(0.5250698f, -0.05013971f, 0.8495809f, t.y),
					 new Vector4(-0.4247904f, 0.8495809f, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7374651f, 0.5250698f, 0.4247904f, t.x),
					 new Vector4(0.5250698f, -0.05013971f, -0.8495809f, t.y),
					 new Vector4(0.4247904f, -0.8495809f, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, -0.4247904f, -0.8495809f, t.x),
					 new Vector4(-0.4247904f, 0.7374651f, -0.5250698f, t.y),
					 new Vector4(-0.8495809f, -0.5250698f, -0.05013971f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, -0.4247904f, 0.8495809f, t.x),
					 new Vector4(-0.4247904f, 0.7374651f, 0.5250698f, t.y),
					 new Vector4(0.8495809f, 0.5250698f, -0.05013971f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, 0.4247904f, -0.8495809f, t.x),
					 new Vector4(0.4247904f, 0.7374651f, 0.5250698f, t.y),
					 new Vector4(-0.8495809f, 0.5250698f, -0.05013971f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, 0.4247904f, 0.8495809f, t.x),
					 new Vector4(0.4247904f, 0.7374651f, -0.5250698f, t.y),
					 new Vector4(0.8495809f, -0.5250698f, -0.05013971f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.3126746f, 0, -0.9498603f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(-0.9498603f, 0, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.3126746f, 0, 0.9498603f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0.9498603f, 0, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, -0.9498603f, 0, t.x),
					 new Vector4(-0.9498603f, -0.3126746f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, 0.9498603f, 0, t.x),
					 new Vector4(0.9498603f, -0.3126746f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 0.3126746f, -0.9498603f, t.y),
					 new Vector4(0, -0.9498603f, -0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, 0.3126746f, 0.9498603f, t.y),
					 new Vector4(0, 0.9498603f, -0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v60_rID_J(Vector3 t)
	{
		return new Matrix4x4[30] {
				 new Matrix4x4(
					 new Vector4(-0.7994412f, -0.4247904f, -0.4247904f, t.x),
					 new Vector4(-0.4247904f, 0.8997206f, -0.1002794f, t.y),
					 new Vector4(-0.4247904f, -0.1002794f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.7994412f, -0.4247904f, 0.4247904f, t.x),
					 new Vector4(-0.4247904f, 0.8997206f, 0.1002794f, t.y),
					 new Vector4(0.4247904f, 0.1002794f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.7994412f, 0.4247904f, -0.4247904f, t.x),
					 new Vector4(0.4247904f, 0.8997206f, 0.1002794f, t.y),
					 new Vector4(-0.4247904f, 0.1002794f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.7994412f, 0.4247904f, 0.4247904f, t.x),
					 new Vector4(0.4247904f, 0.8997206f, -0.1002794f, t.y),
					 new Vector4(0.4247904f, -0.1002794f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, -0.4247904f, -0.1002794f, t.x),
					 new Vector4(-0.4247904f, -0.7994412f, -0.4247904f, t.y),
					 new Vector4(-0.1002794f, -0.4247904f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, -0.4247904f, 0.1002794f, t.x),
					 new Vector4(-0.4247904f, -0.7994412f, 0.4247904f, t.y),
					 new Vector4(0.1002794f, 0.4247904f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, 0.4247904f, -0.1002794f, t.x),
					 new Vector4(0.4247904f, -0.7994412f, 0.4247904f, t.y),
					 new Vector4(-0.1002794f, 0.4247904f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, 0.4247904f, 0.1002794f, t.x),
					 new Vector4(0.4247904f, -0.7994412f, -0.4247904f, t.y),
					 new Vector4(0.1002794f, -0.4247904f, 0.8997206f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, -0.1002794f, -0.4247904f, t.x),
					 new Vector4(-0.1002794f, 0.8997206f, -0.4247904f, t.y),
					 new Vector4(-0.4247904f, -0.4247904f, -0.7994412f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, -0.1002794f, 0.4247904f, t.x),
					 new Vector4(-0.1002794f, 0.8997206f, 0.4247904f, t.y),
					 new Vector4(0.4247904f, 0.4247904f, -0.7994412f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, 0.1002794f, -0.4247904f, t.x),
					 new Vector4(0.1002794f, 0.8997206f, 0.4247904f, t.y),
					 new Vector4(-0.4247904f, 0.4247904f, -0.7994412f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.8997206f, 0.1002794f, 0.4247904f, t.x),
					 new Vector4(0.1002794f, 0.8997206f, -0.4247904f, t.y),
					 new Vector4(0.4247904f, -0.4247904f, -0.7994412f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.05013971f, -0.5250698f, -0.8495809f, t.x),
					 new Vector4(-0.5250698f, 0.7374651f, -0.4247904f, t.y),
					 new Vector4(-0.8495809f, -0.4247904f, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.05013971f, -0.5250698f, 0.8495809f, t.x),
					 new Vector4(-0.5250698f, 0.7374651f, 0.4247904f, t.y),
					 new Vector4(0.8495809f, 0.4247904f, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.05013971f, 0.5250698f, -0.8495809f, t.x),
					 new Vector4(0.5250698f, 0.7374651f, 0.4247904f, t.y),
					 new Vector4(-0.8495809f, 0.4247904f, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.05013971f, 0.5250698f, 0.8495809f, t.x),
					 new Vector4(0.5250698f, 0.7374651f, -0.4247904f, t.y),
					 new Vector4(0.8495809f, -0.4247904f, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, -0.8495809f, -0.4247904f, t.x),
					 new Vector4(-0.8495809f, -0.05013971f, -0.5250698f, t.y),
					 new Vector4(-0.4247904f, -0.5250698f, 0.7374651f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, -0.8495809f, 0.4247904f, t.x),
					 new Vector4(-0.8495809f, -0.05013971f, 0.5250698f, t.y),
					 new Vector4(0.4247904f, 0.5250698f, 0.7374651f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, 0.8495809f, -0.4247904f, t.x),
					 new Vector4(0.8495809f, -0.05013971f, 0.5250698f, t.y),
					 new Vector4(-0.4247904f, 0.5250698f, 0.7374651f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, 0.8495809f, 0.4247904f, t.x),
					 new Vector4(0.8495809f, -0.05013971f, -0.5250698f, t.y),
					 new Vector4(0.4247904f, -0.5250698f, 0.7374651f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7374651f, -0.4247904f, -0.5250698f, t.x),
					 new Vector4(-0.4247904f, 0.3126746f, -0.8495809f, t.y),
					 new Vector4(-0.5250698f, -0.8495809f, -0.05013971f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7374651f, -0.4247904f, 0.5250698f, t.x),
					 new Vector4(-0.4247904f, 0.3126746f, 0.8495809f, t.y),
					 new Vector4(0.5250698f, 0.8495809f, -0.05013971f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7374651f, 0.4247904f, -0.5250698f, t.x),
					 new Vector4(0.4247904f, 0.3126746f, 0.8495809f, t.y),
					 new Vector4(-0.5250698f, 0.8495809f, -0.05013971f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.7374651f, 0.4247904f, 0.5250698f, t.x),
					 new Vector4(0.4247904f, 0.3126746f, -0.8495809f, t.y),
					 new Vector4(0.5250698f, -0.8495809f, -0.05013971f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.3126746f, -0.9498603f, 0, t.x),
					 new Vector4(-0.9498603f, 0.3126746f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(-0.3126746f, 0.9498603f, 0, t.x),
					 new Vector4(0.9498603f, 0.3126746f, 0, t.y),
					 new Vector4(0, 0, 1, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -0.3126746f, -0.9498603f, t.y),
					 new Vector4(0, -0.9498603f, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(1, 0, 0, t.x),
					 new Vector4(0, -0.3126746f, 0.9498603f, t.y),
					 new Vector4(0, 0.9498603f, 0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, 0, -0.9498603f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(-0.9498603f, 0, -0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1)),
				 new Matrix4x4(
					 new Vector4(0.3126746f, 0, 0.9498603f, t.x),
					 new Vector4(0, 1, 0, t.y),
					 new Vector4(0.9498603f, 0, -0.3126746f, t.z),
					 new Vector4(0, 0, 0, 1))
			};
	}
	public static Matrix4x4[] v120_tID_G(Vector3 t)
	{
		return new Matrix4x4[60] {
				new Matrix4x4(
					new Vector4(-1, -0.2676611f, -0.2676611f, t.x),
					new Vector4(-0.2676611f, 0.9641788f, -0.03582123f, t.y),
					new Vector4(-0.2676611f, -0.03582123f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-1, -0.2676611f, 0.2676611f, t.x),
					new Vector4(-0.2676611f, 0.9641788f, 0.03582123f, t.y),
					new Vector4(0.2676611f, 0.03582123f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-1, 0.2676611f, -0.2676611f, t.x),
					new Vector4(0.2676611f, 0.9641788f, 0.03582123f, t.y),
					new Vector4(-0.2676611f, 0.03582123f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-1, 0.2676611f, 0.2676611f, t.x),
					new Vector4(0.2676611f, 0.9641788f, -0.03582123f, t.y),
					new Vector4(0.2676611f, -0.03582123f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.2676611f, -0.03582123f, t.x),
					new Vector4(-0.2676611f, -1, -0.2676611f, t.y),
					new Vector4(-0.03582123f, -0.2676611f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.2676611f, 0.03582123f, t.x),
					new Vector4(-0.2676611f, -1, 0.2676611f, t.y),
					new Vector4(0.03582123f, 0.2676611f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.2676611f, -0.03582123f, t.x),
					new Vector4(0.2676611f, -1, 0.2676611f, t.y),
					new Vector4(-0.03582123f, 0.2676611f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.2676611f, 0.03582123f, t.x),
					new Vector4(0.2676611f, -1, -0.2676611f, t.y),
					new Vector4(0.03582123f, -0.2676611f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.03582123f, -0.2676611f, t.x),
					new Vector4(-0.03582123f, 0.9641788f, -0.2676611f, t.y),
					new Vector4(-0.2676611f, -0.2676611f, -1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.03582123f, 0.2676611f, t.x),
					new Vector4(-0.03582123f, 0.9641788f, 0.2676611f, t.y),
					new Vector4(0.2676611f, 0.2676611f, -1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.03582123f, -0.2676611f, t.x),
					new Vector4(0.03582123f, 0.9641788f, 0.2676611f, t.y),
					new Vector4(-0.2676611f, 0.2676611f, -1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.03582123f, 0.2676611f, t.x),
					new Vector4(0.03582123f, 0.9641788f, -0.2676611f, t.y),
					new Vector4(0.2676611f, -0.2676611f, -1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.6828352f, -0.4910447f, -0.6427858f, t.x),
					new Vector4(-0.4910447f, 0.8567151f, -0.1875624f, t.y),
					new Vector4(-0.6427858f, -0.1875624f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.6828352f, -0.4910447f, 0.6427858f, t.x),
					new Vector4(-0.4910447f, 0.8567151f, 0.1875624f, t.y),
					new Vector4(0.6427858f, 0.1875624f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.6828352f, 0.4910447f, -0.6427858f, t.x),
					new Vector4(0.4910447f, 0.8567151f, 0.1875624f, t.y),
					new Vector4(-0.6427858f, 0.1875624f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.6828352f, 0.4910447f, 0.6427858f, t.x),
					new Vector4(0.4910447f, 0.8567151f, -0.1875624f, t.y),
					new Vector4(0.6427858f, -0.1875624f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, -0.6427858f, -0.1875624f, t.x),
					new Vector4(-0.6427858f, -0.6828352f, -0.4910447f, t.y),
					new Vector4(-0.1875624f, -0.4910447f, 0.8567151f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, -0.6427858f, 0.1875624f, t.x),
					new Vector4(-0.6427858f, -0.6828352f, 0.4910447f, t.y),
					new Vector4(0.1875624f, 0.4910447f, 0.8567151f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, 0.6427858f, -0.1875624f, t.x),
					new Vector4(0.6427858f, -0.6828352f, 0.4910447f, t.y),
					new Vector4(-0.1875624f, 0.4910447f, 0.8567151f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, 0.6427858f, 0.1875624f, t.x),
					new Vector4(0.6427858f, -0.6828352f, -0.4910447f, t.y),
					new Vector4(0.1875624f, -0.4910447f, 0.8567151f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8567151f, -0.1875624f, -0.4910447f, t.x),
					new Vector4(-0.1875624f, 0.7544777f, -0.6427858f, t.y),
					new Vector4(-0.4910447f, -0.6427858f, -0.6828352f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8567151f, -0.1875624f, 0.4910447f, t.x),
					new Vector4(-0.1875624f, 0.7544777f, 0.6427858f, t.y),
					new Vector4(0.4910447f, 0.6427858f, -0.6828352f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8567151f, 0.1875624f, -0.4910447f, t.x),
					new Vector4(0.1875624f, 0.7544777f, 0.6427858f, t.y),
					new Vector4(-0.4910447f, 0.6427858f, -0.6828352f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8567151f, 0.1875624f, 0.4910447f, t.x),
					new Vector4(0.1875624f, 0.7544777f, -0.6427858f, t.y),
					new Vector4(0.4910447f, -0.6427858f, -0.6828352f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.3930354f, -0.2233836f, -0.4731341f, t.x),
					new Vector4(-0.2233836f, 0.9641788f, -0.1517412f, t.y),
					new Vector4(-0.4731341f, -0.1517412f, 0.3572142f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.3930354f, -0.2233836f, 0.4731341f, t.x),
					new Vector4(-0.2233836f, 0.9641788f, 0.1517412f, t.y),
					new Vector4(0.4731341f, 0.1517412f, 0.3572142f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.3930354f, 0.2233836f, -0.4731341f, t.x),
					new Vector4(0.2233836f, 0.9641788f, 0.1517412f, t.y),
					new Vector4(-0.4731341f, 0.1517412f, 0.3572142f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.3930354f, 0.2233836f, 0.4731341f, t.x),
					new Vector4(0.2233836f, 0.9641788f, -0.1517412f, t.y),
					new Vector4(0.4731341f, -0.1517412f, 0.3572142f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.3572142f, -0.4731341f, -0.1517412f, t.x),
					new Vector4(-0.4731341f, -0.3930354f, -0.2233836f, t.y),
					new Vector4(-0.1517412f, -0.2233836f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.3572142f, -0.4731341f, 0.1517412f, t.x),
					new Vector4(-0.4731341f, -0.3930354f, 0.2233836f, t.y),
					new Vector4(0.1517412f, 0.2233836f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.3572142f, 0.4731341f, -0.1517412f, t.x),
					new Vector4(0.4731341f, -0.3930354f, 0.2233836f, t.y),
					new Vector4(-0.1517412f, 0.2233836f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.3572142f, 0.4731341f, 0.1517412f, t.x),
					new Vector4(0.4731341f, -0.3930354f, -0.2233836f, t.y),
					new Vector4(0.1517412f, -0.2233836f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.1517412f, -0.2233836f, t.x),
					new Vector4(-0.1517412f, 0.3572142f, -0.4731341f, t.y),
					new Vector4(-0.2233836f, -0.4731341f, -0.3930354f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.1517412f, 0.2233836f, t.x),
					new Vector4(-0.1517412f, 0.3572142f, 0.4731341f, t.y),
					new Vector4(0.2233836f, 0.4731341f, -0.3930354f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.1517412f, -0.2233836f, t.x),
					new Vector4(0.1517412f, 0.3572142f, 0.4731341f, t.y),
					new Vector4(-0.2233836f, 0.4731341f, -0.3930354f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.1517412f, 0.2233836f, t.x),
					new Vector4(0.1517412f, 0.3572142f, -0.4731341f, t.y),
					new Vector4(0.2233836f, -0.4731341f, -0.3930354f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.2276117f, -0.7587058f, -0.678607f, t.x),
					new Vector4(-0.7587058f, 0.531094f, -0.4194022f, t.y),
					new Vector4(-0.678607f, -0.4194022f, 0.6248752f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.2276117f, -0.7587058f, 0.678607f, t.x),
					new Vector4(-0.7587058f, 0.531094f, 0.4194022f, t.y),
					new Vector4(0.678607f, 0.4194022f, 0.6248752f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.2276117f, 0.7587058f, -0.678607f, t.x),
					new Vector4(0.7587058f, 0.531094f, 0.4194022f, t.y),
					new Vector4(-0.678607f, 0.4194022f, 0.6248752f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.2276117f, 0.7587058f, 0.678607f, t.x),
					new Vector4(0.7587058f, 0.531094f, -0.4194022f, t.y),
					new Vector4(0.678607f, -0.4194022f, 0.6248752f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6248752f, -0.678607f, -0.4194022f, t.x),
					new Vector4(-0.678607f, -0.2276117f, -0.7587058f, t.y),
					new Vector4(-0.4194022f, -0.7587058f, 0.531094f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6248752f, -0.678607f, 0.4194022f, t.x),
					new Vector4(-0.678607f, -0.2276117f, 0.7587058f, t.y),
					new Vector4(0.4194022f, 0.7587058f, 0.531094f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6248752f, 0.678607f, -0.4194022f, t.x),
					new Vector4(0.678607f, -0.2276117f, 0.7587058f, t.y),
					new Vector4(-0.4194022f, 0.7587058f, 0.531094f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6248752f, 0.678607f, 0.4194022f, t.x),
					new Vector4(0.678607f, -0.2276117f, -0.7587058f, t.y),
					new Vector4(0.4194022f, -0.7587058f, 0.531094f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.531094f, -0.4194022f, -0.7587058f, t.x),
					new Vector4(-0.4194022f, 0.6248752f, -0.678607f, t.y),
					new Vector4(-0.7587058f, -0.678607f, -0.2276117f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.531094f, -0.4194022f, 0.7587058f, t.x),
					new Vector4(-0.4194022f, 0.6248752f, 0.678607f, t.y),
					new Vector4(0.7587058f, 0.678607f, -0.2276117f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.531094f, 0.4194022f, -0.7587058f, t.x),
					new Vector4(0.4194022f, 0.6248752f, 0.678607f, t.y),
					new Vector4(-0.7587058f, 0.678607f, -0.2276117f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.531094f, 0.4194022f, 0.7587058f, t.x),
					new Vector4(0.4194022f, 0.6248752f, -0.678607f, t.y),
					new Vector4(0.7587058f, -0.678607f, -0.2276117f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.01791061f, -0.4910447f, -0.9104469f, t.x),
					new Vector4(-0.4910447f, 0.7544777f, -0.4552235f, t.y),
					new Vector4(-0.9104469f, -0.4552235f, 0.1559693f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.01791061f, -0.4910447f, 0.9104469f, t.x),
					new Vector4(-0.4910447f, 0.7544777f, 0.4552235f, t.y),
					new Vector4(0.9104469f, 0.4552235f, 0.1559693f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.01791061f, 0.4910447f, -0.9104469f, t.x),
					new Vector4(0.4910447f, 0.7544777f, 0.4552235f, t.y),
					new Vector4(-0.9104469f, 0.4552235f, 0.1559693f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.01791061f, 0.4910447f, 0.9104469f, t.x),
					new Vector4(0.4910447f, 0.7544777f, -0.4552235f, t.y),
					new Vector4(0.9104469f, -0.4552235f, 0.1559693f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.1559693f, -0.9104469f, -0.4552235f, t.x),
					new Vector4(-0.9104469f, 0.01791061f, -0.4910447f, t.y),
					new Vector4(-0.4552235f, -0.4910447f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.1559693f, -0.9104469f, 0.4552235f, t.x),
					new Vector4(-0.9104469f, 0.01791061f, 0.4910447f, t.y),
					new Vector4(0.4552235f, 0.4910447f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.1559693f, 0.9104469f, -0.4552235f, t.x),
					new Vector4(0.9104469f, 0.01791061f, 0.4910447f, t.y),
					new Vector4(-0.4552235f, 0.4910447f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.1559693f, 0.9104469f, 0.4552235f, t.x),
					new Vector4(0.9104469f, 0.01791061f, -0.4910447f, t.y),
					new Vector4(0.4552235f, -0.4910447f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, -0.4552235f, -0.4910447f, t.x),
					new Vector4(-0.4552235f, 0.1559693f, -0.9104469f, t.y),
					new Vector4(-0.4910447f, -0.9104469f, 0.01791061f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, -0.4552235f, 0.4910447f, t.x),
					new Vector4(-0.4552235f, 0.1559693f, 0.9104469f, t.y),
					new Vector4(0.4910447f, 0.9104469f, 0.01791061f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, 0.4552235f, -0.4910447f, t.x),
					new Vector4(0.4552235f, 0.1559693f, 0.9104469f, t.y),
					new Vector4(-0.4910447f, 0.9104469f, 0.01791061f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, 0.4552235f, 0.4910447f, t.x),
					new Vector4(0.4552235f, 0.1559693f, -0.9104469f, t.y),
					new Vector4(0.4910447f, -0.9104469f, 0.01791061f, t.z),
					new Vector4(0, 0, 0, 1))
		};
	}
	public static Matrix4x4[] v120_tID_J(Vector3 t)
	{
		return new Matrix4x4[60] {
				new Matrix4x4(
					new Vector4(-1, -0.2676611f, -0.2676611f, t.x),
					new Vector4(-0.2676611f, 0.9641788f, -0.03582123f, t.y),
					new Vector4(-0.2676611f, -0.03582123f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-1, -0.2676611f, 0.2676611f, t.x),
					new Vector4(-0.2676611f, 0.9641788f, 0.03582123f, t.y),
					new Vector4(0.2676611f, 0.03582123f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-1, 0.2676611f, -0.2676611f, t.x),
					new Vector4(0.2676611f, 0.9641788f, 0.03582123f, t.y),
					new Vector4(-0.2676611f, 0.03582123f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-1, 0.2676611f, 0.2676611f, t.x),
					new Vector4(0.2676611f, 0.9641788f, -0.03582123f, t.y),
					new Vector4(0.2676611f, -0.03582123f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.2676611f, -0.03582123f, t.x),
					new Vector4(-0.2676611f, -1, -0.2676611f, t.y),
					new Vector4(-0.03582123f, -0.2676611f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.2676611f, 0.03582123f, t.x),
					new Vector4(-0.2676611f, -1, 0.2676611f, t.y),
					new Vector4(0.03582123f, 0.2676611f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.2676611f, -0.03582123f, t.x),
					new Vector4(0.2676611f, -1, 0.2676611f, t.y),
					new Vector4(-0.03582123f, 0.2676611f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.2676611f, 0.03582123f, t.x),
					new Vector4(0.2676611f, -1, -0.2676611f, t.y),
					new Vector4(0.03582123f, -0.2676611f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.03582123f, -0.2676611f, t.x),
					new Vector4(-0.03582123f, 0.9641788f, -0.2676611f, t.y),
					new Vector4(-0.2676611f, -0.2676611f, -1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.03582123f, 0.2676611f, t.x),
					new Vector4(-0.03582123f, 0.9641788f, 0.2676611f, t.y),
					new Vector4(0.2676611f, 0.2676611f, -1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.03582123f, -0.2676611f, t.x),
					new Vector4(0.03582123f, 0.9641788f, 0.2676611f, t.y),
					new Vector4(-0.2676611f, 0.2676611f, -1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.03582123f, 0.2676611f, t.x),
					new Vector4(0.03582123f, 0.9641788f, -0.2676611f, t.y),
					new Vector4(0.2676611f, -0.2676611f, -1, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.6828352f, -0.6427858f, -0.4910447f, t.x),
					new Vector4(-0.6427858f, 0.7544777f, -0.1875624f, t.y),
					new Vector4(-0.4910447f, -0.1875624f, 0.8567151f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.6828352f, -0.6427858f, 0.4910447f, t.x),
					new Vector4(-0.6427858f, 0.7544777f, 0.1875624f, t.y),
					new Vector4(0.4910447f, 0.1875624f, 0.8567151f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.6828352f, 0.6427858f, -0.4910447f, t.x),
					new Vector4(0.6427858f, 0.7544777f, 0.1875624f, t.y),
					new Vector4(-0.4910447f, 0.1875624f, 0.8567151f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.6828352f, 0.6427858f, 0.4910447f, t.x),
					new Vector4(0.6427858f, 0.7544777f, -0.1875624f, t.y),
					new Vector4(0.4910447f, -0.1875624f, 0.8567151f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8567151f, -0.4910447f, -0.1875624f, t.x),
					new Vector4(-0.4910447f, -0.6828352f, -0.6427858f, t.y),
					new Vector4(-0.1875624f, -0.6427858f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8567151f, -0.4910447f, 0.1875624f, t.x),
					new Vector4(-0.4910447f, -0.6828352f, 0.6427858f, t.y),
					new Vector4(0.1875624f, 0.6427858f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8567151f, 0.4910447f, -0.1875624f, t.x),
					new Vector4(0.4910447f, -0.6828352f, 0.6427858f, t.y),
					new Vector4(-0.1875624f, 0.6427858f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.8567151f, 0.4910447f, 0.1875624f, t.x),
					new Vector4(0.4910447f, -0.6828352f, -0.6427858f, t.y),
					new Vector4(0.1875624f, -0.6427858f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, -0.1875624f, -0.6427858f, t.x),
					new Vector4(-0.1875624f, 0.8567151f, -0.4910447f, t.y),
					new Vector4(-0.6427858f, -0.4910447f, -0.6828352f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, -0.1875624f, 0.6427858f, t.x),
					new Vector4(-0.1875624f, 0.8567151f, 0.4910447f, t.y),
					new Vector4(0.6427858f, 0.4910447f, -0.6828352f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, 0.1875624f, -0.6427858f, t.x),
					new Vector4(0.1875624f, 0.8567151f, 0.4910447f, t.y),
					new Vector4(-0.6427858f, 0.4910447f, -0.6828352f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, 0.1875624f, 0.6427858f, t.x),
					new Vector4(0.1875624f, 0.8567151f, -0.4910447f, t.y),
					new Vector4(0.6427858f, -0.4910447f, -0.6828352f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.3930354f, -0.4731341f, -0.2233836f, t.x),
					new Vector4(-0.4731341f, 0.3572142f, -0.1517412f, t.y),
					new Vector4(-0.2233836f, -0.1517412f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.3930354f, -0.4731341f, 0.2233836f, t.x),
					new Vector4(-0.4731341f, 0.3572142f, 0.1517412f, t.y),
					new Vector4(0.2233836f, 0.1517412f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.3930354f, 0.4731341f, -0.2233836f, t.x),
					new Vector4(0.4731341f, 0.3572142f, 0.1517412f, t.y),
					new Vector4(-0.2233836f, 0.1517412f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.3930354f, 0.4731341f, 0.2233836f, t.x),
					new Vector4(0.4731341f, 0.3572142f, -0.1517412f, t.y),
					new Vector4(0.2233836f, -0.1517412f, 0.9641788f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.2233836f, -0.1517412f, t.x),
					new Vector4(-0.2233836f, -0.3930354f, -0.4731341f, t.y),
					new Vector4(-0.1517412f, -0.4731341f, 0.3572142f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, -0.2233836f, 0.1517412f, t.x),
					new Vector4(-0.2233836f, -0.3930354f, 0.4731341f, t.y),
					new Vector4(0.1517412f, 0.4731341f, 0.3572142f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.2233836f, -0.1517412f, t.x),
					new Vector4(0.2233836f, -0.3930354f, 0.4731341f, t.y),
					new Vector4(-0.1517412f, 0.4731341f, 0.3572142f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.9641788f, 0.2233836f, 0.1517412f, t.x),
					new Vector4(0.2233836f, -0.3930354f, -0.4731341f, t.y),
					new Vector4(0.1517412f, -0.4731341f, 0.3572142f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.3572142f, -0.1517412f, -0.4731341f, t.x),
					new Vector4(-0.1517412f, 0.9641788f, -0.2233836f, t.y),
					new Vector4(-0.4731341f, -0.2233836f, -0.3930354f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.3572142f, -0.1517412f, 0.4731341f, t.x),
					new Vector4(-0.1517412f, 0.9641788f, 0.2233836f, t.y),
					new Vector4(0.4731341f, 0.2233836f, -0.3930354f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.3572142f, 0.1517412f, -0.4731341f, t.x),
					new Vector4(0.1517412f, 0.9641788f, 0.2233836f, t.y),
					new Vector4(-0.4731341f, 0.2233836f, -0.3930354f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.3572142f, 0.1517412f, 0.4731341f, t.x),
					new Vector4(0.1517412f, 0.9641788f, -0.2233836f, t.y),
					new Vector4(0.4731341f, -0.2233836f, -0.3930354f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.2276117f, -0.678607f, -0.7587058f, t.x),
					new Vector4(-0.678607f, 0.6248752f, -0.4194022f, t.y),
					new Vector4(-0.7587058f, -0.4194022f, 0.531094f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.2276117f, -0.678607f, 0.7587058f, t.x),
					new Vector4(-0.678607f, 0.6248752f, 0.4194022f, t.y),
					new Vector4(0.7587058f, 0.4194022f, 0.531094f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.2276117f, 0.678607f, -0.7587058f, t.x),
					new Vector4(0.678607f, 0.6248752f, 0.4194022f, t.y),
					new Vector4(-0.7587058f, 0.4194022f, 0.531094f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(-0.2276117f, 0.678607f, 0.7587058f, t.x),
					new Vector4(0.678607f, 0.6248752f, -0.4194022f, t.y),
					new Vector4(0.7587058f, -0.4194022f, 0.531094f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.531094f, -0.7587058f, -0.4194022f, t.x),
					new Vector4(-0.7587058f, -0.2276117f, -0.678607f, t.y),
					new Vector4(-0.4194022f, -0.678607f, 0.6248752f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.531094f, -0.7587058f, 0.4194022f, t.x),
					new Vector4(-0.7587058f, -0.2276117f, 0.678607f, t.y),
					new Vector4(0.4194022f, 0.678607f, 0.6248752f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.531094f, 0.7587058f, -0.4194022f, t.x),
					new Vector4(0.7587058f, -0.2276117f, 0.678607f, t.y),
					new Vector4(-0.4194022f, 0.678607f, 0.6248752f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.531094f, 0.7587058f, 0.4194022f, t.x),
					new Vector4(0.7587058f, -0.2276117f, -0.678607f, t.y),
					new Vector4(0.4194022f, -0.678607f, 0.6248752f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6248752f, -0.4194022f, -0.678607f, t.x),
					new Vector4(-0.4194022f, 0.531094f, -0.7587058f, t.y),
					new Vector4(-0.678607f, -0.7587058f, -0.2276117f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6248752f, -0.4194022f, 0.678607f, t.x),
					new Vector4(-0.4194022f, 0.531094f, 0.7587058f, t.y),
					new Vector4(0.678607f, 0.7587058f, -0.2276117f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6248752f, 0.4194022f, -0.678607f, t.x),
					new Vector4(0.4194022f, 0.531094f, 0.7587058f, t.y),
					new Vector4(-0.678607f, 0.7587058f, -0.2276117f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.6248752f, 0.4194022f, 0.678607f, t.x),
					new Vector4(0.4194022f, 0.531094f, -0.7587058f, t.y),
					new Vector4(0.678607f, -0.7587058f, -0.2276117f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.01791061f, -0.9104469f, -0.4910447f, t.x),
					new Vector4(-0.9104469f, 0.1559693f, -0.4552235f, t.y),
					new Vector4(-0.4910447f, -0.4552235f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.01791061f, -0.9104469f, 0.4910447f, t.x),
					new Vector4(-0.9104469f, 0.1559693f, 0.4552235f, t.y),
					new Vector4(0.4910447f, 0.4552235f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.01791061f, 0.9104469f, -0.4910447f, t.x),
					new Vector4(0.9104469f, 0.1559693f, 0.4552235f, t.y),
					new Vector4(-0.4910447f, 0.4552235f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.01791061f, 0.9104469f, 0.4910447f, t.x),
					new Vector4(0.9104469f, 0.1559693f, -0.4552235f, t.y),
					new Vector4(0.4910447f, -0.4552235f, 0.7544777f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, -0.4910447f, -0.4552235f, t.x),
					new Vector4(-0.4910447f, 0.01791061f, -0.9104469f, t.y),
					new Vector4(-0.4552235f, -0.9104469f, 0.1559693f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, -0.4910447f, 0.4552235f, t.x),
					new Vector4(-0.4910447f, 0.01791061f, 0.9104469f, t.y),
					new Vector4(0.4552235f, 0.9104469f, 0.1559693f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, 0.4910447f, -0.4552235f, t.x),
					new Vector4(0.4910447f, 0.01791061f, 0.9104469f, t.y),
					new Vector4(-0.4552235f, 0.9104469f, 0.1559693f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.7544777f, 0.4910447f, 0.4552235f, t.x),
					new Vector4(0.4910447f, 0.01791061f, -0.9104469f, t.y),
					new Vector4(0.4552235f, -0.9104469f, 0.1559693f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.1559693f, -0.4552235f, -0.9104469f, t.x),
					new Vector4(-0.4552235f, 0.7544777f, -0.4910447f, t.y),
					new Vector4(-0.9104469f, -0.4910447f, 0.01791061f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.1559693f, -0.4552235f, 0.9104469f, t.x),
					new Vector4(-0.4552235f, 0.7544777f, 0.4910447f, t.y),
					new Vector4(0.9104469f, 0.4910447f, 0.01791061f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.1559693f, 0.4552235f, -0.9104469f, t.x),
					new Vector4(0.4552235f, 0.7544777f, 0.4910447f, t.y),
					new Vector4(-0.9104469f, 0.4910447f, 0.01791061f, t.z),
					new Vector4(0, 0, 0, 1)),
				new Matrix4x4(
					new Vector4(0.1559693f, 0.4552235f, 0.9104469f, t.x),
					new Vector4(0.4552235f, 0.7544777f, -0.4910447f, t.y),
					new Vector4(0.9104469f, -0.4910447f, 0.01791061f, t.z),
					new Vector4(0, 0, 0, 1))
		};
	}
}
