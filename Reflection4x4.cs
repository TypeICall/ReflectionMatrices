using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Reflection4x4
{
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
     */

    public static Matrix4x4[] v6_O = new Matrix4x4[3] {
             new Matrix4x4(
                 new Vector4(-1, 0, 0, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -1, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0, 0, -1, 0),
                 new Vector4(0, 0, 0, 1))
    };
    public static Matrix4x4[] v8_C = new Matrix4x4[4] {
             new Matrix4x4(
                 new Vector4(0.3333333f, -0.6666667f, -0.6666667f, 0),
                 new Vector4(-0.6666667f, 0.3333333f, -0.6666667f, 0),
                 new Vector4(-0.6666667f, -0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3333333f, -0.6666667f, 0.6666667f, 0),
                 new Vector4(-0.6666667f, 0.3333333f, 0.6666667f, 0),
                 new Vector4(0.6666667f, 0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3333333f, 0.6666667f, -0.6666667f, 0),
                 new Vector4(0.6666667f, 0.3333333f, 0.6666667f, 0),
                 new Vector4(-0.6666667f, 0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3333333f, 0.6666667f, 0.6666667f, 0),
                 new Vector4(0.6666667f, 0.3333333f, -0.6666667f, 0),
                 new Vector4(0.6666667f, -0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1))
    };
    public static Matrix4x4[] v12_CO = new Matrix4x4[6] {
             new Matrix4x4(
                 new Vector4(0, -1, 0, 0),
                 new Vector4(-1, 0, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0, 1, 0, 0),
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0, -1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0, 0, -1, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-1, 0, 0, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0, -1, 0),
                 new Vector4(0, -1, 0, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-1, 0, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0, 0, 0, 1))
    };
    public static Matrix4x4[] v12_tT = new Matrix4x4[12] {
             new Matrix4x4(
                 new Vector4(-0.6363636f, -0.5454546f, -0.5454546f, 0),
                 new Vector4(-0.5454546f, 0.8181818f, -0.1818182f, 0),
                 new Vector4(-0.5454546f, -0.1818182f, 0.8181818f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6363636f, -0.5454546f, 0.5454546f, 0),
                 new Vector4(-0.5454546f, 0.8181818f, 0.1818182f, 0),
                 new Vector4(0.5454546f, 0.1818182f, 0.8181818f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6363636f, 0.5454546f, -0.5454546f, 0),
                 new Vector4(0.5454546f, 0.8181818f, 0.1818182f, 0),
                 new Vector4(-0.5454546f, 0.1818182f, 0.8181818f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6363636f, 0.5454546f, 0.5454546f, 0),
                 new Vector4(0.5454546f, 0.8181818f, -0.1818182f, 0),
                 new Vector4(0.5454546f, -0.1818182f, 0.8181818f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8181818f, -0.5454546f, -0.1818182f, 0),
                 new Vector4(-0.5454546f, -0.6363636f, -0.5454546f, 0),
                 new Vector4(-0.1818182f, -0.5454546f, 0.8181818f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8181818f, -0.5454546f, 0.1818182f, 0),
                 new Vector4(-0.5454546f, -0.6363636f, 0.5454546f, 0),
                 new Vector4(0.1818182f, 0.5454546f, 0.8181818f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8181818f, 0.5454546f, -0.1818182f, 0),
                 new Vector4(0.5454546f, -0.6363636f, 0.5454546f, 0),
                 new Vector4(-0.1818182f, 0.5454546f, 0.8181818f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8181818f, 0.5454546f, 0.1818182f, 0),
                 new Vector4(0.5454546f, -0.6363636f, -0.5454546f, 0),
                 new Vector4(0.1818182f, -0.5454546f, 0.8181818f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8181818f, -0.1818182f, -0.5454546f, 0),
                 new Vector4(-0.1818182f, 0.8181818f, -0.5454546f, 0),
                 new Vector4(-0.5454546f, -0.5454546f, -0.6363636f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8181818f, -0.1818182f, 0.5454546f, 0),
                 new Vector4(-0.1818182f, 0.8181818f, 0.5454546f, 0),
                 new Vector4(0.5454546f, 0.5454546f, -0.6363636f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8181818f, 0.1818182f, -0.5454546f, 0),
                 new Vector4(0.1818182f, 0.8181818f, 0.5454546f, 0),
                 new Vector4(-0.5454546f, 0.5454546f, -0.6363636f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8181818f, 0.1818182f, 0.5454546f, 0),
                 new Vector4(0.1818182f, 0.8181818f, -0.5454546f, 0),
                 new Vector4(0.5454546f, -0.5454546f, -0.6363636f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v24_tO = new Matrix4x4[12] {
             new Matrix4x4(
                 new Vector4(-0.6f, -0.8f, 0f, 0),
                 new Vector4(-0.8f, 0.6f, 0f, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6f, 0.8f, 0, 0),
                 new Vector4(0.8f, 0.6f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6f, -0.8f, 0, 0),
                 new Vector4(-0.8f, -0.6f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6f, 0.8f, 0, 0),
                 new Vector4(0.8f, -0.6f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6f, 0, -0.8f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.8f, 0, 0.6f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6f, 0, 0.8f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0.8f, 0, 0.6f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6f, 0, -0.8f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.8f, 0, -0.6f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6f, 0, 0.8f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0.8f, 0, -0.6f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.6f, -0.8f, 0),
                 new Vector4(0, -0.8f, 0.6f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.6f, 0.8f, 0),
                 new Vector4(0, 0.8f, 0.6f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0.6f, -0.8f, 0),
                 new Vector4(0, -0.8f, -0.6f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0.6f, 0.8f, 0),
                 new Vector4(0, 0.8f, -0.6f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v24_tC = new Matrix4x4[12] {
             new Matrix4x4(
                 new Vector4(0.07900857f, -0.9209914f, -0.3814871f, 0),
                 new Vector4(-0.9209914f, 0.07900857f, -0.3814871f, 0),
                 new Vector4(-0.3814871f, -0.3814871f, 0.8419828f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.07900857f, -0.9209914f, 0.3814871f, 0),
                 new Vector4(-0.9209914f, 0.07900857f, 0.3814871f, 0),
                 new Vector4(0.3814871f, 0.3814871f, 0.8419828f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.07900857f, 0.9209914f, -0.3814871f, 0),
                 new Vector4(0.9209914f, 0.07900857f, 0.3814871f, 0),
                 new Vector4(-0.3814871f, 0.3814871f, 0.8419828f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.07900857f, 0.9209914f, 0.3814871f, 0),
                 new Vector4(0.9209914f, 0.07900857f, -0.3814871f, 0),
                 new Vector4(0.3814871f, -0.3814871f, 0.8419828f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.07900857f, -0.3814871f, -0.9209914f, 0),
                 new Vector4(-0.3814871f, 0.8419828f, -0.3814871f, 0),
                 new Vector4(-0.9209914f, -0.3814871f, 0.07900857f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.07900857f, -0.3814871f, 0.9209914f, 0),
                 new Vector4(-0.3814871f, 0.8419828f, 0.3814871f, 0),
                 new Vector4(0.9209914f, 0.3814871f, 0.07900857f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.07900857f, 0.3814871f, -0.9209914f, 0),
                 new Vector4(0.3814871f, 0.8419828f, 0.3814871f, 0),
                 new Vector4(-0.9209914f, 0.3814871f, 0.07900857f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.07900857f, 0.3814871f, 0.9209914f, 0),
                 new Vector4(0.3814871f, 0.8419828f, -0.3814871f, 0),
                 new Vector4(0.9209914f, -0.3814871f, 0.07900857f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8419828f, -0.3814871f, -0.3814871f, 0),
                 new Vector4(-0.3814871f, 0.07900857f, -0.9209914f, 0),
                 new Vector4(-0.3814871f, -0.9209914f, 0.07900857f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8419828f, -0.3814871f, 0.3814871f, 0),
                 new Vector4(-0.3814871f, 0.07900857f, 0.9209914f, 0),
                 new Vector4(0.3814871f, 0.9209914f, 0.07900857f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8419828f, 0.3814871f, -0.3814871f, 0),
                 new Vector4(0.3814871f, 0.07900857f, 0.9209914f, 0),
                 new Vector4(-0.3814871f, 0.9209914f, 0.07900857f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8419828f, 0.3814871f, 0.3814871f, 0),
                 new Vector4(0.3814871f, 0.07900857f, -0.9209914f, 0),
                 new Vector4(0.3814871f, -0.9209914f, 0.07900857f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v24_rCO = new Matrix4x4[12] {
             new Matrix4x4(
                 new Vector4(-0.4890417f, -0.6167812f, -0.6167812f, 0),
                 new Vector4(-0.6167812f, 0.7445208f, -0.2554792f, 0),
                 new Vector4(-0.6167812f, -0.2554792f, 0.7445208f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.4890417f, -0.6167812f, 0.6167812f, 0),
                 new Vector4(-0.6167812f, 0.7445208f, 0.2554792f, 0),
                 new Vector4(0.6167812f, 0.2554792f, 0.7445208f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.4890417f, 0.6167812f, -0.6167812f, 0),
                 new Vector4(0.6167812f, 0.7445208f, 0.2554792f, 0),
                 new Vector4(-0.6167812f, 0.2554792f, 0.7445208f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.4890417f, 0.6167812f, 0.6167812f, 0),
                 new Vector4(0.6167812f, 0.7445208f, -0.2554792f, 0),
                 new Vector4(0.6167812f, -0.2554792f, 0.7445208f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7445208f, -0.6167812f, -0.2554792f, 0),
                 new Vector4(-0.6167812f, -0.4890417f, -0.6167812f, 0),
                 new Vector4(-0.2554792f, -0.6167812f, 0.7445208f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7445208f, -0.6167812f, 0.2554792f, 0),
                 new Vector4(-0.6167812f, -0.4890417f, 0.6167812f, 0),
                 new Vector4(0.2554792f, 0.6167812f, 0.7445208f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7445208f, 0.6167812f, -0.2554792f, 0),
                 new Vector4(0.6167812f, -0.4890417f, 0.6167812f, 0),
                 new Vector4(-0.2554792f, 0.6167812f, 0.7445208f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7445208f, 0.6167812f, 0.2554792f, 0),
                 new Vector4(0.6167812f, -0.4890417f, -0.6167812f, 0),
                 new Vector4(0.2554792f, -0.6167812f, 0.7445208f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7445208f, -0.2554792f, -0.6167812f, 0),
                 new Vector4(-0.2554792f, 0.7445208f, -0.6167812f, 0),
                 new Vector4(-0.6167812f, -0.6167812f, -0.4890417f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7445208f, -0.2554792f, 0.6167812f, 0),
                 new Vector4(-0.2554792f, 0.7445208f, 0.6167812f, 0),
                 new Vector4(0.6167812f, 0.6167812f, -0.4890417f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7445208f, 0.2554792f, -0.6167812f, 0),
                 new Vector4(0.2554792f, 0.7445208f, 0.6167812f, 0),
                 new Vector4(-0.6167812f, 0.6167812f, -0.4890417f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7445208f, 0.2554792f, 0.6167812f, 0),
                 new Vector4(0.2554792f, 0.7445208f, -0.6167812f, 0),
                 new Vector4(0.6167812f, -0.6167812f, -0.4890417f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v48_tCO = new Matrix4x4[24] {
             new Matrix4x4(
                 new Vector4(-0.3643623f, -0.8603695f, -0.3563767f, 0),
                 new Vector4(-0.8603695f, 0.4574493f, -0.2247318f, 0),
                 new Vector4(-0.3563767f, -0.2247318f, 0.906913f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3643623f, -0.8603695f, 0.3563767f, 0),
                 new Vector4(-0.8603695f, 0.4574493f, 0.2247318f, 0),
                 new Vector4(0.3563767f, 0.2247318f, 0.906913f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3643623f, 0.8603695f, -0.3563767f, 0),
                 new Vector4(0.8603695f, 0.4574493f, 0.2247318f, 0),
                 new Vector4(-0.3563767f, 0.2247318f, 0.906913f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3643623f, 0.8603695f, 0.3563767f, 0),
                 new Vector4(0.8603695f, 0.4574493f, -0.2247318f, 0),
                 new Vector4(0.3563767f, -0.2247318f, 0.906913f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3643623f, -0.3563767f, -0.8603695f, 0),
                 new Vector4(-0.3563767f, 0.906913f, -0.2247318f, 0),
                 new Vector4(-0.8603695f, -0.2247318f, 0.4574493f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3643623f, -0.3563767f, 0.8603695f, 0),
                 new Vector4(-0.3563767f, 0.906913f, 0.2247318f, 0),
                 new Vector4(0.8603695f, 0.2247318f, 0.4574493f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3643623f, 0.3563767f, -0.8603695f, 0),
                 new Vector4(0.3563767f, 0.906913f, 0.2247318f, 0),
                 new Vector4(-0.8603695f, 0.2247318f, 0.4574493f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3643623f, 0.3563767f, 0.8603695f, 0),
                 new Vector4(0.3563767f, 0.906913f, -0.2247318f, 0),
                 new Vector4(0.8603695f, -0.2247318f, 0.4574493f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.4574493f, -0.8603695f, -0.2247318f, 0),
                 new Vector4(-0.8603695f, -0.3643623f, -0.3563767f, 0),
                 new Vector4(-0.2247318f, -0.3563767f, 0.906913f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.4574493f, -0.8603695f, 0.2247318f, 0),
                 new Vector4(-0.8603695f, -0.3643623f, 0.3563767f, 0),
                 new Vector4(0.2247318f, 0.3563767f, 0.906913f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.4574493f, 0.8603695f, -0.2247318f, 0),
                 new Vector4(0.8603695f, -0.3643623f, 0.3563767f, 0),
                 new Vector4(-0.2247318f, 0.3563767f, 0.906913f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.4574493f, 0.8603695f, 0.2247318f, 0),
                 new Vector4(0.8603695f, -0.3643623f, -0.3563767f, 0),
                 new Vector4(0.2247318f, -0.3563767f, 0.906913f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.906913f, -0.3563767f, -0.2247318f, 0),
                 new Vector4(-0.3563767f, -0.3643623f, -0.8603695f, 0),
                 new Vector4(-0.2247318f, -0.8603695f, 0.4574493f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.906913f, -0.3563767f, 0.2247318f, 0),
                 new Vector4(-0.3563767f, -0.3643623f, 0.8603695f, 0),
                 new Vector4(0.2247318f, 0.8603695f, 0.4574493f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.906913f, 0.3563767f, -0.2247318f, 0),
                 new Vector4(0.3563767f, -0.3643623f, 0.8603695f, 0),
                 new Vector4(-0.2247318f, 0.8603695f, 0.4574493f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.906913f, 0.3563767f, 0.2247318f, 0),
                 new Vector4(0.3563767f, -0.3643623f, -0.8603695f, 0),
                 new Vector4(0.2247318f, -0.8603695f, 0.4574493f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.4574493f, -0.2247318f, -0.8603695f, 0),
                 new Vector4(-0.2247318f, 0.906913f, -0.3563767f, 0),
                 new Vector4(-0.8603695f, -0.3563767f, -0.3643623f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.4574493f, -0.2247318f, 0.8603695f, 0),
                 new Vector4(-0.2247318f, 0.906913f, 0.3563767f, 0),
                 new Vector4(0.8603695f, 0.3563767f, -0.3643623f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.4574493f, 0.2247318f, -0.8603695f, 0),
                 new Vector4(0.2247318f, 0.906913f, 0.3563767f, 0),
                 new Vector4(-0.8603695f, 0.3563767f, -0.3643623f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.4574493f, 0.2247318f, 0.8603695f, 0),
                 new Vector4(0.2247318f, 0.906913f, -0.3563767f, 0),
                 new Vector4(0.8603695f, -0.3563767f, -0.3643623f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.906913f, -0.2247318f, -0.3563767f, 0),
                 new Vector4(-0.2247318f, 0.4574493f, -0.8603695f, 0),
                 new Vector4(-0.3563767f, -0.8603695f, -0.3643623f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.906913f, -0.2247318f, 0.3563767f, 0),
                 new Vector4(-0.2247318f, 0.4574493f, 0.8603695f, 0),
                 new Vector4(0.3563767f, 0.8603695f, -0.3643623f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.906913f, 0.2247318f, -0.3563767f, 0),
                 new Vector4(0.2247318f, 0.4574493f, 0.8603695f, 0),
                 new Vector4(-0.3563767f, 0.8603695f, -0.3643623f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.906913f, 0.2247318f, 0.3563767f, 0),
                 new Vector4(0.2247318f, 0.4574493f, -0.8603695f, 0),
                 new Vector4(0.3563767f, -0.8603695f, -0.3643623f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v12_I_G = new Matrix4x4[6] {
             new Matrix4x4(
                 new Vector4(0.4472136f, -0.8944272f, 0, 0),
                 new Vector4(-0.8944272f, -0.4472136f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.4472136f, 0.8944272f, 0, 0),
                 new Vector4(0.8944272f, -0.4472136f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.4472136f, 0, -0.8944272f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.8944272f, 0, 0.4472136f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.4472136f, 0, 0.8944272f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0.8944272f, 0, 0.4472136f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0.4472136f, -0.8944272f, 0),
                 new Vector4(0, -0.8944272f, -0.4472136f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0.4472136f, 0.8944272f, 0),
                 new Vector4(0, 0.8944272f, -0.4472136f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v12_I_J = new Matrix4x4[6] {
             new Matrix4x4(
                 new Vector4(-0.4472136f, -0.8944272f, 0, 0),
                 new Vector4(-0.8944272f, 0.4472136f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.4472136f, 0.8944272f, 0, 0),
                 new Vector4(0.8944272f, 0.4472136f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.4472136f, 0, -0.8944272f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.8944272f, 0, -0.4472136f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.4472136f, 0, 0.8944272f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0.8944272f, 0, -0.4472136f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.4472136f, -0.8944272f, 0),
                 new Vector4(0, -0.8944272f, 0.4472136f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.4472136f, 0.8944272f, 0),
                 new Vector4(0, 0.8944272f, 0.4472136f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v20_D_G = new Matrix4x4[10] {
             new Matrix4x4(
                 new Vector4(-0.745356f, -0.6666667f, 0, 0),
                 new Vector4(-0.6666667f, 0.745356f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.745356f, 0.6666667f, 0, 0),
                 new Vector4(0.6666667f, 0.745356f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.745356f, 0, -0.6666667f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.6666667f, 0, -0.745356f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.745356f, 0, 0.6666667f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0.6666667f, 0, -0.745356f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.745356f, -0.6666667f, 0),
                 new Vector4(0, -0.6666667f, 0.745356f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.745356f, 0.6666667f, 0),
                 new Vector4(0, 0.6666667f, 0.745356f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3333333f, -0.6666667f, -0.6666667f, 0),
                 new Vector4(-0.6666667f, 0.3333333f, -0.6666667f, 0),
                 new Vector4(-0.6666667f, -0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3333333f, -0.6666667f, 0.6666667f, 0),
                 new Vector4(-0.6666667f, 0.3333333f, 0.6666667f, 0),
                 new Vector4(0.6666667f, 0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3333333f, 0.6666667f, -0.6666667f, 0),
                 new Vector4(0.6666667f, 0.3333333f, 0.6666667f, 0),
                 new Vector4(-0.6666667f, 0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3333333f, 0.6666667f, 0.6666667f, 0),
                 new Vector4(0.6666667f, 0.3333333f, -0.6666667f, 0),
                 new Vector4(0.6666667f, -0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v20_D_J = new Matrix4x4[10] {
             new Matrix4x4(
                 new Vector4(0.745356f, -0.6666667f, 0, 0),
                 new Vector4(-0.6666667f, -0.745356f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.745356f, 0.6666667f, 0, 0),
                 new Vector4(0.6666667f, -0.745356f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.745356f, 0, -0.6666667f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.6666667f, 0, 0.745356f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.745356f, 0, 0.6666667f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0.6666667f, 0f, 0.745356f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0.745356f, -0.6666667f, 0),
                 new Vector4(0, -0.6666667f, -0.745356f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0.745356f, 0.6666667f, 0),
                 new Vector4(0, 0.6666667f, -0.745356f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3333333f, -0.6666667f, -0.6666667f, 0),
                 new Vector4(-0.6666667f, 0.3333333f, -0.6666667f, 0),
                 new Vector4(-0.6666667f, -0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3333333f, -0.6666667f, 0.6666667f, 0),
                 new Vector4(-0.6666667f, 0.3333333f, 0.6666667f, 0),
                 new Vector4(0.6666667f, 0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3333333f, 0.6666667f, -0.6666667f, 0),
                 new Vector4(0.6666667f, 0.3333333f, 0.6666667f, 0),
                 new Vector4(-0.6666667f, 0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3333333f, 0.6666667f, 0.6666667f, 0),
                 new Vector4(0.6666667f, 0.3333333f, -0.6666667f, 0),
                 new Vector4(0.6666667f, -0.6666667f, 0.3333333f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v30_ID_G = new Matrix4x4[15] {
             new Matrix4x4(
                 new Vector4(-1, 0, 0, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -1, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0, 0, -1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.309017f, -0.809017f, -0.5f, 0),
                 new Vector4(-0.809017f, 0.5f, -0.309017f, 0),
                 new Vector4(-0.5f, -0.309017f, 0.809017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.309017f, -0.809017f, 0.5f, 0),
                 new Vector4(-0.809017f, 0.5f, 0.309017f, 0),
                 new Vector4(0.5f, 0.309017f, 0.809017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.309017f, 0.809017f, -0.5f, 0),
                 new Vector4(0.809017f, 0.5f, 0.309017f, 0),
                 new Vector4(-0.5f, 0.309017f, 0.809017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.309017f, 0.809017f, 0.5f, 0),
                 new Vector4(0.809017f, 0.5f, -0.309017f, 0),
                 new Vector4(0.5f, -0.309017f, 0.809017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.5f, -0.309017f, -0.809017f, 0),
                 new Vector4(-0.309017f, 0.809017f, -0.5f, 0),
                 new Vector4(-0.809017f, -0.5f, -0.309017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.5f, -0.309017f, 0.809017f, 0),
                 new Vector4(-0.309017f, 0.809017f, 0.5f, 0),
                 new Vector4(0.809017f, 0.5f, -0.309017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.5f, 0.309017f, -0.809017f, 0),
                 new Vector4(0.309017f, 0.809017f, 0.5f, 0),
                 new Vector4(-0.809017f, 0.5f, -0.309017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.5f, 0.309017f, 0.809017f, 0),
                 new Vector4(0.309017f, 0.809017f, -0.5f, 0),
                 new Vector4(0.809017f, -0.5f, -0.309017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.809017f, -0.5f, -0.309017f, 0),
                 new Vector4(-0.5f, -0.309017f, -0.809017f, 0),
                 new Vector4(-0.309017f, -0.809017f, 0.5f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.809017f, -0.5f, 0.309017f, 0),
                 new Vector4(-0.5f, -0.309017f, 0.809017f, 0),
                 new Vector4(0.309017f, 0.809017f, 0.5f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.809017f, 0.5f, -0.309017f, 0),
                 new Vector4(0.5f, -0.309017f, 0.809017f, 0),
                 new Vector4(-0.309017f, 0.809017f, 0.5f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.809017f, 0.5f, 0.309017f, 0),
                 new Vector4(0.5f, -0.309017f, -0.809017f, 0),
                 new Vector4(0.309017f, -0.809017f, 0.5f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v30_ID_J = new Matrix4x4[15] {
             new Matrix4x4(
                 new Vector4(-1, 0, 0, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -1, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0, 0, -1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.309017f, -0.5f, -0.809017f, 0),
                 new Vector4(-0.5f, 0.809017f, -0.309017f, 0),
                 new Vector4(-0.809017f, -0.309017f, 0.5f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.309017f, -0.5f, 0.809017f, 0),
                 new Vector4(-0.5f, 0.809017f, 0.309017f, 0),
                 new Vector4(0.809017f, 0.309017f, 0.5f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.309017f, 0.5f, -0.809017f, 0),
                 new Vector4(0.5f, 0.809017f, 0.309017f, 0),
                 new Vector4(-0.809017f, 0.309017f, 0.5f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.309017f, 0.5f, 0.809017f, 0),
                 new Vector4(0.5f, 0.809017f, -0.309017f, 0),
                 new Vector4(0.809017f, -0.309017f, 0.5f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.809017f, -0.309017f, -0.5f, 0),
                 new Vector4(-0.309017f, 0.5f, -0.809017f, 0),
                 new Vector4(-0.5f, -0.809017f, -0.309017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.809017f, -0.309017f, 0.5f, 0),
                 new Vector4(-0.309017f, 0.5f, 0.809017f, 0),
                 new Vector4(0.5f, 0.809017f, -0.309017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.809017f, 0.309017f, -0.5f, 0),
                 new Vector4(0.309017f, 0.5f, 0.809017f, 0),
                 new Vector4(-0.5f, 0.809017f, -0.309017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.809017f, 0.309017f, 0.5f, 0),
                 new Vector4(0.309017f, 0.5f, -0.809017f, 0),
                 new Vector4(0.5f, -0.809017f, -0.309017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.5f, -0.809017f, -0.309017f, 0),
                 new Vector4(-0.809017f, -0.309017f, -0.5f, 0),
                 new Vector4(-0.309017f, -0.5f, 0.809017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.5f, -0.809017f, 0.309017f, 0),
                 new Vector4(-0.809017f, -0.309017f, 0.5f, 0),
                 new Vector4(0.309017f, 0.5f, 0.809017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.5f, 0.809017f, -0.309017f, 0),
                 new Vector4(0.809017f, -0.309017f, 0.5f, 0),
                 new Vector4(-0.309017f, 0.5f, 0.809017f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.5f, 0.809017f, 0.309017f, 0),
                 new Vector4(0.809017f, -0.309017f, -0.5f, 0),
                 new Vector4(0.309017f, -0.5f, 0.809017f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v60_tI_G = new Matrix4x4[30] {
             new Matrix4x4(
                 new Vector4(-0.9185744f, -0.197624f, 0, 0),
                 new Vector4(-0.197624f, 0.9592872f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.9185744f, 0.197624f, 0, 0),
                 new Vector4(0.197624f, 0.9592872f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9592872f, 0, -0.197624f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.197624f, 0, -0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9592872f, 0, 0.197624f, 0),
                 new Vector4(0f, 1, 0, 0),
                 new Vector4(0.197624f, 0, -0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.9185744f, -0.197624f, 0),
                 new Vector4(0, -0.197624f, 0.9592872f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.9185744f, 0.197624f, 0),
                 new Vector4(0, 0.197624f, 0.9592872f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.06587468f, -0.1473003f, -0.4766736f, 0),
                 new Vector4(-0.1473003f, 0.9185744f, -0.1317494f, 0),
                 new Vector4(-0.4766736f, -0.1317494f, 0.1473003f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.06587468f, -0.1473003f, 0.4766736f, 0),
                 new Vector4(-0.1473003f, 0.9185744f, 0.1317494f, 0),
                 new Vector4(0.4766736f, 0.1317494f, 0.1473003f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.06587468f, 0.1473003f, -0.4766736f, 0),
                 new Vector4(0.1473003f, 0.9185744f, 0.1317494f, 0),
                 new Vector4(-0.4766736f, 0.1317494f, 0.1473003f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.06587468f, 0.1473003f, 0.4766736f, 0),
                 new Vector4(0.1473003f, 0.9185744f, -0.1317494f, 0),
                 new Vector4(0.4766736f, -0.1317494f, 0.1473003f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1473003f, -0.4766736f, -0.1317494f, 0),
                 new Vector4(-0.4766736f, -0.06587468f, -0.1473003f, 0),
                 new Vector4(-0.1317494f, -0.1473003f, 0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1473003f, -0.4766736f, 0.1317494f, 0),
                 new Vector4(-0.4766736f, -0.06587468f, 0.1473003f, 0),
                 new Vector4(0.1317494f, 0.1473003f, 0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1473003f, 0.4766736f, -0.1317494f, 0),
                 new Vector4(0.4766736f, -0.06587468f, 0.1473003f, 0),
                 new Vector4(-0.1317494f, 0.1473003f, 0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1473003f, 0.4766736f, 0.1317494f, 0),
                 new Vector4(0.4766736f, -0.06587468f, -0.1473003f, 0),
                 new Vector4(0.1317494f, -0.1473003f, 0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9185744f, -0.1317494f, -0.1473003f, 0),
                 new Vector4(-0.1317494f, 0.1473003f, -0.4766736f, 0),
                 new Vector4(-0.1473003f, -0.4766736f, -0.06587468f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9185744f, -0.1317494f, 0.1473003f, 0),
                 new Vector4(-0.1317494f, 0.1473003f, 0.4766736f, 0),
                 new Vector4(0.1473003f, 0.4766736f, -0.06587468f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9185744f, 0.1317494f, -0.1473003f, 0),
                 new Vector4(0.1317494f, 0.1473003f, 0.4766736f, 0),
                 new Vector4(-0.1473003f, 0.4766736f, -0.06587468f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9185744f, 0.1317494f, 0.1473003f, 0),
                 new Vector4(0.1317494f, 0.1473003f, -0.4766736f, 0),
                 new Vector4(0.1473003f, -0.4766736f, -0.06587468f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.188013f, -0.1724622f, -0.1395248f, 0),
                 new Vector4(-0.1724622f, 0.6742977f, -0.08623108f, 0),
                 new Vector4(-0.1395248f, -0.08623108f, 0.7868251f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.188013f, -0.1724622f, 0.1395248f, 0),
                 new Vector4(-0.1724622f, 0.6742977f, -0.08623108f, 0),
                 new Vector4(0.1395248f, 0.08623108f, 0.7868251f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.188013f, 0.1724622f, -0.1395248f, 0),
                 new Vector4(0.1724622f, 0.6742977f, 0.08623108f, 0),
                 new Vector4(-0.1395248f, 0.08623108f, 0.7868251f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.188013f, 0.1724622f, 0.1395248f, 0),
                 new Vector4(0.1724622f, 0.6742977f, -0.08623108f, 0),
                 new Vector4(0.1395248f, -0.08623108f, 0.7868251f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7868251f, -0.1395248f, -0.08623108f, 0),
                 new Vector4(-0.1395248f, -0.188013f, -0.1724622f, 0),
                 new Vector4(-0.08623108f, -0.1724622f, 0.6742977f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7868251f, -0.1395248f, 0.08623108f, 0),
                 new Vector4(-0.1395248f, -0.188013f, 0.1724622f, 0),
                 new Vector4(0.08623108f, 0.1724622f, 0.6742977f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7868251f, 0.1395248f, -0.08623108f, 0),
                 new Vector4(0.1395248f, -0.188013f, 0.1724622f, 0),
                 new Vector4(-0.08623108f, 0.1724622f, 0.6742977f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7868251f, 0.1395248f, 0.08623108f, 0),
                 new Vector4(0.1395248f, -0.188013f, -0.1724622f, 0),
                 new Vector4(0.08623108f, -0.1724622f, 0.6742977f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6742977f, -0.08623108f, -0.1724622f, 0),
                 new Vector4(-0.08623108f, 0.7868251f, -0.1395248f, 0),
                 new Vector4(-0.1724622f, -0.1395248f, -0.188013f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6742977f, -0.08623108f, 0.1724622f, 0),
                 new Vector4(-0.08623108f, 0.7868251f, 0.1395248f, 0),
                 new Vector4(0.1724622f, 0.1395248f, -0.188013f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6742977f, 0.08623108f, -0.1724622f, 0),
                 new Vector4(0.08623108f, 0.7868251f, 0.1395248f, 0),
                 new Vector4(-0.1724622f, 0.1395248f, -0.188013f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6742977f, 0.08623108f, 0.1724622f, 0),
                 new Vector4(0.08623108f, 0.7868251f, -0.1395248f, 0),
                 new Vector4(0.1724622f, -0.1395248f, -0.188013f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v60_tI_J = new Matrix4x4[30] {
             new Matrix4x4(
                 new Vector4(0.9185744f, -0.197624f, 0, 0),
                 new Vector4(-0.197624f, -0.9592872f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9185744f, 0.197624f, 0, 0),
                 new Vector4(0.197624f, -0.9592872f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.9592872f, 0f, -0.197624f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.197624f, 0f, 0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.9592872f, 0f, 0.197624f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0.197624f, 0f, 0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0f, 0.9185744f, -0.197624f, 0),
                 new Vector4(0f, -0.197624f, -0.9592872f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0f, 0.9185744f, 0.197624f, 0),
                 new Vector4(0f, 0.197624f, -0.9592872f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.06587468f, -0.4766736f, -0.1473003f, 0),
                 new Vector4(-0.4766736f, 0.1473003f, -0.1317494f, 0),
                 new Vector4(-0.1473003f, -0.1317494f, 0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.06587468f, 0.4766736f, -0.1473003f, 0),
                 new Vector4(0.4766736f, 0.1473003f, 0.1317494f, 0),
                 new Vector4(-0.1473003f, 0.1317494f, 0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.06587468f, 0.4766736f, -0.1473003f, 0),
                 new Vector4(0.4766736f, 0.1473003f, 0.1317494f, 0),
                 new Vector4(-0.1473003f, 0.1317494f, 0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.06587468f, 0.4766736f, 0.1473003f, 0),
                 new Vector4(0.4766736f, 0.1473003f, -0.1317494f, 0),
                 new Vector4(0.1473003f, -0.1317494f, 0.9185744f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9185744f, -0.1473003f, -0.1317494f, 0),
                 new Vector4(-0.1473003f, -0.06587468f, -0.4766736f, 0),
                 new Vector4(-0.1317494f, -0.4766736f, 0.1473003f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9185744f, -0.1473003f, 0.1317494f, 0),
                 new Vector4(-0.1473003f, -0.06587468f, 0.4766736f, 0),
                 new Vector4(0.1317494f, 0.4766736f, 0.1473003f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9185744f, 0.1473003f, -0.1317494f, 0),
                 new Vector4(0.1473003f, -0.06587468f, 0.4766736f, 0),
                 new Vector4(-0.1317494f, 0.4766736f, 0.1473003f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9185744f, 0.1473003f, 0.1317494f, 0),
                 new Vector4(0.1473003f, -0.06587468f, -0.4766736f, 0),
                 new Vector4(0.1317494f, -0.4766736f, 0.1473003f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1473003f, -0.1317494f, -0.4766736f, 0),
                 new Vector4(-0.1317494f, 0.9185744f, -0.1473003f, 0),
                 new Vector4(-0.4766736f, -0.1473003f, -0.06587468f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1473003f, -0.1317494f, 0.4766736f, 0),
                 new Vector4(-0.1317494f, 0.9185744f, 0.1473003f, 0),
                 new Vector4(0.4766736f, 0.1473003f, -0.06587468f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1473003f, 0.1317494f, -0.4766736f, 0),
                 new Vector4(0.1317494f, 0.9185744f, 0.1473003f, 0),
                 new Vector4(-0.4766736f, 0.1473003f, -0.06587468f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1473003f, 0.1317494f, 0.4766736f, 0),
                 new Vector4(0.1317494f, 0.9185744f, -0.1473003f, 0),
                 new Vector4(0.4766736f, -0.1473003f, -0.06587468f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.188013f, -0.1395248f, -0.1724622f, 0),
                 new Vector4(-0.1395248f, 0.7868251f, -0.08623108f, 0),
                 new Vector4(-0.1724622f, -0.08623108f, 0.6742977f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.188013f, -0.1395248f, 0.1724622f, 0),
                 new Vector4(-0.1395248f, 0.7868251f, 0.08623108f, 0),
                 new Vector4(0.1724622f, 0.08623108f, 0.6742977f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.188013f, 0.1395248f, -0.1724622f, 0),
                 new Vector4(0.1395248f, 0.7868251f, 0.08623108f, 0),
                 new Vector4(-0.1724622f, 0.08623108f, 0.6742977f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.188013f, 0.1395248f, 0.1724622f, 0),
                 new Vector4(0.1395248f, 0.7868251f, -0.08623108f, 0),
                 new Vector4(0.1724622f, -0.08623108f, 0.6742977f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6742977f, -0.1724622f, -0.08623108f, 0),
                 new Vector4(-0.1724622f, -0.188013f, -0.1395248f, 0),
                 new Vector4(-0.08623108f, -0.1395248f, 0.7868251f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6742977f, -0.1724622f, 0.08623108f, 0),
                 new Vector4(-0.1724622f, -0.188013f, 0.1395248f, 0),
                 new Vector4(0.08623108f, 0.1395248f, 0.7868251f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6742977f, 0.1724622f, -0.08623108f, 0),
                 new Vector4(0.1724622f, -0.188013f, 0.1395248f, 0),
                 new Vector4(-0.08623108f, 0.1395248f, 0.7868251f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6742977f, 0.1724622f, 0.08623108f, 0),
                 new Vector4(0.1724622f, -0.188013f, -0.1395248f, 0),
                 new Vector4(0.08623108f, -0.1395248f, 0.7868251f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7868251f, -0.08623108f, -0.1395248f, 0),
                 new Vector4(-0.08623108f, 0.6742977f, -0.1724622f, 0),
                 new Vector4(-0.1395248f, -0.1724622f, -0.188013f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7868251f, -0.08623108f, 0.1395248f, 0),
                 new Vector4(-0.08623108f, 0.6742977f, 0.1724622f, 0),
                 new Vector4(0.1395248f, 0.1724622f, -0.188013f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7868251f, 0.08623108f, -0.1395248f, 0),
                 new Vector4(0.08623108f, 0.6742977f, 0.1724622f, 0),
                 new Vector4(-0.1395248f, 0.1724622f, -0.188013f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7868251f, 0.08623108f, 0.1395248f, 0),
                 new Vector4(0.08623108f, 0.6742977f, -0.1724622f, 0),
                 new Vector4(0.1395248f, -0.1724622f, -0.188013f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v60_tD_G = new Matrix4x4[30] {
             new Matrix4x4(
                 new Vector4(-0.9432954f, -0.08298862f, 0, 0),
                 new Vector4(-0.08298862f, 0.9432954f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.9432954f, 0.08298862f, 0, 0),
                 new Vector4(0.08298862f, 0.9432954f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9432954f, 0, -0.08298862f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.08298862f, 0, -0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9432954f, 0, 0.08298862f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0.08298862f, 0, -0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.9432954f, -0.08298862f, 0),
                 new Vector4(0, -0.08298862f, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.9432954f, 0.08298862f, 0),
                 new Vector4(0, 0.08298862f, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.5546363f, -0.07422728f, -0.1943295f, 0),
                 new Vector4(-0.07422728f, 0.9432954f, -0.03711364f, 0),
                 new Vector4(-0.1943295f, -0.03711364f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.5546363f, -0.07422728f, 0.1943295f, 0),
                 new Vector4(-0.07422728f, 0.9432954f, 0.03711364f, 0),
                 new Vector4(0.1943295f, 0.03711364f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.5546363f, 0.07422728f, -0.1943295f, 0),
                 new Vector4(0.07422728f, 0.9432954f, 0.03711364f, 0),
                 new Vector4(-0.1943295f, 0.03711364f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.5546363f, 0.07422728f, 0.1943295f, 0),
                 new Vector4(0.07422728f, 0.9432954f, -0.03711364f, 0),
                 new Vector4(0.1943295f, -0.03711364f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, -0.1943295f, -0.03711364f, 0),
                 new Vector4(-0.1943295f, -0.5546363f, -0.07422728f, 0),
                 new Vector4(-0.03711364f, -0.07422728f, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, -0.1943295f, 0.03711364f, 0),
                 new Vector4(-0.1943295f, -0.5546363f, 0.07422728f, 0),
                 new Vector4(0.03711364f, 0.07422728f, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, 0.1943295f, -0.03711364f, 0),
                 new Vector4(0.1943295f, -0.5546363f, 0.07422728f, 0),
                 new Vector4(-0.03711364f, 0.07422728f, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, 0.1943295f, 0.03711364f, 0),
                 new Vector4(0.1943295f, -0.5546363f, -0.07422728f, 0),
                 new Vector4(0.03711364f, -0.07422728f, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9432954f, -0.03711364f, -0.07422728f, 0),
                 new Vector4(-0.03711364f, 0.6113409f, -0.1943295f, 0),
                 new Vector4(-0.07422728f, -0.1943295f, -0.5546363f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9432954f, -0.03711364f, 0.07422728f, 0),
                 new Vector4(-0.03711364f, 0.6113409f, 0.1943295f, 0),
                 new Vector4(0.07422728f, 0.1943295f, -0.5546363f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9432954f, 0.03711364f, -0.07422728f, 0),
                 new Vector4(0.03711364f, 0.6113409f, 0.1943295f, 0),
                 new Vector4(-0.07422728f, 0.1943295f, -0.5546363f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9432954f, 0.03711364f, 0.07422728f, 0),
                 new Vector4(0.03711364f, 0.6113409f, -0.1943295f, 0),
                 new Vector4(0.07422728f, -0.1943295f, -0.5546363f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.01752268f, -0.1572159f, -0.1943295f, 0),
                 new Vector4(-0.1572159f, 0.6113409f, -0.1201023f, 0),
                 new Vector4(-0.1943295f, -0.1201023f, 0.7030909f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.01752268f, -0.1572159f, 0.1943295f, 0),
                 new Vector4(-0.1572159f, 0.6113409f, 0.1201023f, 0),
                 new Vector4(0.1943295f, 0.1201023f, 0.7030909f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.01752268f, 0.1572159f, -0.1943295f, 0),
                 new Vector4(0.1572159f, 0.6113409f, 0.1201023f, 0),
                 new Vector4(-0.1943295f, 0.1201023f, 0.7030909f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.01752268f, 0.1572159f, 0.1943295f, 0),
                 new Vector4(0.1572159f, 0.6113409f, -0.1201023f, 0),
                 new Vector4(0.1943295f, -0.1201023f, 0.7030909f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7030909f, -0.1943295f, -0.1201023f, 0),
                 new Vector4(-0.1943295f, -0.01752268f, -0.1572159f, 0),
                 new Vector4(-0.1201023f, -0.1572159f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7030909f, -0.1943295f, 0.1201023f, 0),
                 new Vector4(-0.1943295f, -0.01752268f, 0.1572159f, 0),
                 new Vector4(0.1201023f, 0.1572159f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7030909f, 0.1943295f, -0.1201023f, 0),
                 new Vector4(0.1943295f, -0.01752268f, 0.1572159f, 0),
                 new Vector4(-0.1201023f, 0.1572159f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7030909f, 0.1943295f, 0.1201023f, 0),
                 new Vector4(0.1943295f, -0.01752268f, -0.1572159f, 0),
                 new Vector4(0.1201023f, -0.1572159f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, -0.1201023f, -0.1572159f, 0),
                 new Vector4(-0.1201023f, 0.7030909f, -0.1943295f, 0),
                 new Vector4(-0.1572159f, -0.1943295f, -0.01752268f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, -0.1201023f, 0.1572159f, 0),
                 new Vector4(-0.1201023f, 0.7030909f, 0.1943295f, 0),
                 new Vector4(0.1572159f, 0.1943295f, -0.01752268f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, 0.1201023f, -0.1572159f, 0),
                 new Vector4(0.1201023f, 0.7030909f, 0.1943295f, 0),
                 new Vector4(-0.1572159f, 0.1943295f, -0.01752268f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, 0.1201023f, 0.1572159f, 0),
                 new Vector4(0.1201023f, 0.7030909f, -0.1943295f, 0),
                 new Vector4(0.1572159f, -0.1943295f, -0.01752268f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v60_tD_J = new Matrix4x4[30] {
             new Matrix4x4(
                 new Vector4(0.9432954f, -0.08298862f, 0, 0),
                 new Vector4(-0.08298862f, -0.9432954f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9432954f, 0.08298862f, 0, 0),
                 new Vector4(0.08298862f, -0.9432954f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.9432954f, 0, -0.08298862f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.08298862f, 0, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.9432954f, 0, 0.08298862f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0.08298862f, 0, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0.9432954f, -0.08298862f, 0),
                 new Vector4(0, -0.08298862f, -0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0.9432954f, 0.08298862f, 0),
                 new Vector4(0, 0.08298862f, -0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.5546363f, -0.1943295f, -0.07422728f, 0),
                 new Vector4(-0.1943295f, 0.6113409f, -0.03711364f, 0),
                 new Vector4(-0.07422728f, -0.03711364f, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.5546363f, -0.1943295f, 0.07422728f, 0),
                 new Vector4(-0.1943295f, 0.6113409f, 0.03711364f, 0),
                 new Vector4(0.07422728f, 0.03711364f, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.5546363f, 0.1943295f, -0.07422728f, 0),
                 new Vector4(0.1943295f, 0.6113409f, 0.03711364f, 0),
                 new Vector4(-0.07422728f, 0.03711364f, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.5546363f, 0.1943295f, 0.07422728f, 0),
                 new Vector4(0.1943295f, 0.6113409f, -0.03711364f, 0),
                 new Vector4(0.07422728f, -0.03711364f, 0.9432954f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9432954f, -0.07422728f, -0.03711364f, 0),
                 new Vector4(-0.07422728f, -0.5546363f, -0.1943295f, 0),
                 new Vector4(-0.03711364f, -0.1943295f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9432954f, -0.07422728f, 0.03711364f, 0),
                 new Vector4(-0.07422728f, -0.5546363f, 0.1943295f, 0),
                 new Vector4(0.03711364f, 0.1943295f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9432954f, 0.07422728f, -0.03711364f, 0),
                 new Vector4(0.07422728f, -0.5546363f, 0.1943295f, 0),
                 new Vector4(-0.03711364f, 0.1943295f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9432954f, 0.07422728f, 0.03711364f, 0),
                 new Vector4(0.07422728f, -0.5546363f, -0.1943295f, 0),
                 new Vector4(0.03711364f, -0.1943295f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, -0.03711364f, -0.1943295f, 0),
                 new Vector4(-0.03711364f, 0.9432954f, -0.07422728f, 0),
                 new Vector4(-0.1943295f, -0.07422728f, -0.5546363f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, -0.03711364f, 0.1943295f, 0),
                 new Vector4(-0.03711364f, 0.9432954f, 0.07422728f, 0),
                 new Vector4(0.1943295f, 0.07422728f, -0.5546363f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, 0.03711364f, -0.1943295f, 0),
                 new Vector4(0.03711364f, 0.9432954f, 0.07422728f, 0),
                 new Vector4(-0.1943295f, 0.07422728f, -0.5546363f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, 0.03711364f, 0.1943295f, 0),
                 new Vector4(0.03711364f, 0.9432954f, -0.07422728f, 0),
                 new Vector4(0.1943295f, -0.07422728f, -0.5546363f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.01752268f, -0.1943295f, -0.1572159f, 0),
                 new Vector4(-0.1943295f, 0.7030909f, -0.1201023f, 0),
                 new Vector4(-0.1572159f, -0.1201023f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.01752268f, -0.1943295f, 0.1572159f, 0),
                 new Vector4(-0.1943295f, 0.7030909f, 0.1201023f, 0),
                 new Vector4(0.1572159f, 0.1201023f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.01752268f, 0.1943295f, -0.1572159f, 0),
                 new Vector4(0.1943295f, 0.7030909f, 0.1201023f, 0),
                 new Vector4(-0.1572159f, 0.1201023f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.01752268f, 0.1943295f, 0.1572159f, 0),
                 new Vector4(0.1943295f, 0.7030909f, -0.1201023f, 0),
                 new Vector4(0.1572159f, -0.1201023f, 0.6113409f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, -0.1572159f, -0.1201023f, 0),
                 new Vector4(-0.1572159f, -0.01752268f, -0.1943295f, 0),
                 new Vector4(-0.1201023f, -0.1943295f, 0.7030909f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, -0.1572159f, 0.1201023f, 0),
                 new Vector4(-0.1572159f, -0.01752268f, 0.1943295f, 0),
                 new Vector4(0.1201023f, 0.1943295f, 0.7030909f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, 0.1572159f, -0.1201023f, 0),
                 new Vector4(0.1572159f, -0.01752268f, 0.1943295f, 0),
                 new Vector4(-0.1201023f, 0.1943295f, 0.7030909f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6113409f, 0.1572159f, 0.1201023f, 0),
                 new Vector4(0.1572159f, -0.01752268f, -0.1943295f, 0),
                 new Vector4(0.1201023f, -0.1943295f, 0.7030909f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7030909f, -0.1201023f, -0.1943295f, 0),
                 new Vector4(-0.1201023f, 0.6113409f, -0.1572159f, 0),
                 new Vector4(-0.1943295f, -0.1572159f, -0.01752268f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7030909f, -0.1201023f, 0.1943295f, 0),
                 new Vector4(-0.1201023f, 0.6113409f, 0.1572159f, 0),
                 new Vector4(0.1943295f, 0.1572159f, -0.01752268f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7030909f, 0.1201023f, -0.1943295f, 0),
                 new Vector4(0.1201023f, 0.6113409f, 0.1572159f, 0),
                 new Vector4(-0.1943295f, 0.1572159f, -0.01752268f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7030909f, 0.1201023f, 0.1943295f, 0),
                 new Vector4(0.1201023f, 0.6113409f, -0.1572159f, 0),
                 new Vector4(0.1943295f, -0.1572159f, -0.01752268f, 0),
                 new Vector4(0, 0, 0, 1)),
    };
    public static Matrix4x4[] v60_rID_G = new Matrix4x4[30] {
             new Matrix4x4(
                 new Vector4(-0.7994412f, -0.4247904f, -0.4247904f, 0),
                 new Vector4(-0.4247904f, 0.8997206f, -0.1002794f, 0),
                 new Vector4(-0.4247904f, -0.1002794f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.7994412f, -0.4247904f, 0.4247904f, 0),
                 new Vector4(-0.4247904f, 0.8997206f, 0.1002794f, 0),
                 new Vector4(0.4247904f, 0.1002794f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.7994412f, 0.4247904f, -0.4247904f, 0),
                 new Vector4(0.4247904f, 0.8997206f, 0.1002794f, 0),
                 new Vector4(-0.4247904f, 0.1002794f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.7994412f, 0.4247904f, 0.4247904f, 0),
                 new Vector4(0.4247904f, 0.8997206f, -0.1002794f, 0),
                 new Vector4(0.4247904f, -0.1002794f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, -0.4247904f, -0.1002794f, 0),
                 new Vector4(-0.4247904f, -0.7994412f, -0.4247904f, 0),
                 new Vector4(-0.1002794f, -0.4247904f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, -0.4247904f, 0.1002794f, 0),
                 new Vector4(-0.4247904f, -0.7994412f, 0.4247904f, 0),
                 new Vector4(0.1002794f, 0.4247904f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, 0.4247904f, -0.1002794f, 0),
                 new Vector4(0.4247904f, -0.7994412f, 0.4247904f, 0),
                 new Vector4(-0.1002794f, 0.4247904f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, 0.4247904f, 0.1002794f, 0),
                 new Vector4(0.4247904f, -0.7994412f, -0.4247904f, 0),
                 new Vector4(0.1002794f, -0.4247904f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, -0.1002794f, -0.4247904f, 0),
                 new Vector4(-0.1002794f, 0.8997206f, -0.4247904f, 0),
                 new Vector4(-0.4247904f, -0.4247904f, -0.7994412f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, -0.1002794f, 0.4247904f, 0),
                 new Vector4(-0.1002794f, 0.8997206f, 0.4247904f, 0),
                 new Vector4(0.4247904f, 0.4247904f, -0.7994412f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, 0.1002794f, -0.4247904f, 0),
                 new Vector4(0.1002794f, 0.8997206f, 0.4247904f, 0),
                 new Vector4(-0.4247904f, 0.4247904f, -0.7994412f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, 0.1002794f, 0.4247904f, 0),
                 new Vector4(0.1002794f, 0.8997206f, -0.4247904f, 0),
                 new Vector4(0.4247904f, -0.4247904f, -0.7994412f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.05013971f, -0.8495809f, -0.5250698f, 0),
                 new Vector4(-0.8495809f, 0.3126746f, -0.4247904f, 0),
                 new Vector4(-0.5250698f, -0.4247904f, 0.7374651f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.05013971f, -0.8495809f, 0.5250698f, 0),
                 new Vector4(-0.8495809f, 0.3126746f, 0.4247904f, 0),
                 new Vector4(0.5250698f, 0.4247904f, 0.7374651f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.05013971f, 0.8495809f, -0.5250698f, 0),
                 new Vector4(0.8495809f, 0.3126746f, 0.4247904f, 0),
                 new Vector4(-0.5250698f, 0.4247904f, 0.7374651f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.05013971f, 0.8495809f, 0.5250698f, 0),
                 new Vector4(0.8495809f, 0.3126746f, -0.4247904f, 0),
                 new Vector4(0.5250698f, -0.4247904f, 0.7374651f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7374651f, -0.5250698f, -0.4247904f, 0),
                 new Vector4(-0.5250698f, -0.05013971f, -0.8495809f, 0),
                 new Vector4(-0.4247904f, -0.8495809f, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7374651f, -0.5250698f, 0.4247904f, 0),
                 new Vector4(-0.5250698f, -0.05013971f, 0.8495809f, 0),
                 new Vector4(0.4247904f, 0.8495809f, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7374651f, 0.5250698f, -0.4247904f, 0),
                 new Vector4(0.5250698f, -0.05013971f, 0.8495809f, 0),
                 new Vector4(-0.4247904f, 0.8495809f, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7374651f, 0.5250698f, 0.4247904f, 0),
                 new Vector4(0.5250698f, -0.05013971f, -0.8495809f, 0),
                 new Vector4(0.4247904f, -0.8495809f, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, -0.4247904f, -0.8495809f, 0),
                 new Vector4(-0.4247904f, 0.7374651f, -0.5250698f, 0),
                 new Vector4(-0.8495809f, -0.5250698f, -0.05013971f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, -0.4247904f, 0.8495809f, 0),
                 new Vector4(-0.4247904f, 0.7374651f, 0.5250698f, 0),
                 new Vector4(0.8495809f, 0.5250698f, -0.05013971f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, 0.4247904f, -0.8495809f, 0),
                 new Vector4(0.4247904f, 0.7374651f, 0.5250698f, 0),
                 new Vector4(-0.8495809f, 0.5250698f, -0.05013971f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, 0.4247904f, 0.8495809f, 0),
                 new Vector4(0.4247904f, 0.7374651f, -0.5250698f, 0),
                 new Vector4(0.8495809f, -0.5250698f, -0.05013971f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3126746f, 0, -0.9498603f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.9498603f, 0, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3126746f, 0, 0.9498603f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0.9498603f, 0, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, -0.9498603f, 0, 0),
                 new Vector4(-0.9498603f, -0.3126746f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, 0.9498603f, 0, 0),
                 new Vector4(0.9498603f, -0.3126746f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0.3126746f, -0.9498603f, 0),
                 new Vector4(0, -0.9498603f, -0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, 0.3126746f, 0.9498603f, 0),
                 new Vector4(0, 0.9498603f, -0.3126746f, 0),
                 new Vector4(0, 0, 0, 1))
    };
    public static Matrix4x4[] v60_rID_J = new Matrix4x4[30] {
             new Matrix4x4(
                 new Vector4(-0.7994412f, -0.4247904f, -0.4247904f, 0),
                 new Vector4(-0.4247904f, 0.8997206f, -0.1002794f, 0),
                 new Vector4(-0.4247904f, -0.1002794f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.7994412f, -0.4247904f, 0.4247904f, 0),
                 new Vector4(-0.4247904f, 0.8997206f, 0.1002794f, 0),
                 new Vector4(0.4247904f, 0.1002794f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.7994412f, 0.4247904f, -0.4247904f, 0),
                 new Vector4(0.4247904f, 0.8997206f, 0.1002794f, 0),
                 new Vector4(-0.4247904f, 0.1002794f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.7994412f, 0.4247904f, 0.4247904f, 0),
                 new Vector4(0.4247904f, 0.8997206f, -0.1002794f, 0),
                 new Vector4(0.4247904f, -0.1002794f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, -0.4247904f, -0.1002794f, 0),
                 new Vector4(-0.4247904f, -0.7994412f, -0.4247904f, 0),
                 new Vector4(-0.1002794f, -0.4247904f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, -0.4247904f, 0.1002794f, 0),
                 new Vector4(-0.4247904f, -0.7994412f, 0.4247904f, 0),
                 new Vector4(0.1002794f, 0.4247904f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, 0.4247904f, -0.1002794f, 0),
                 new Vector4(0.4247904f, -0.7994412f, 0.4247904f, 0),
                 new Vector4(-0.1002794f, 0.4247904f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, 0.4247904f, 0.1002794f, 0),
                 new Vector4(0.4247904f, -0.7994412f, -0.4247904f, 0),
                 new Vector4(0.1002794f, -0.4247904f, 0.8997206f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, -0.1002794f, -0.4247904f, 0),
                 new Vector4(-0.1002794f, 0.8997206f, -0.4247904f, 0),
                 new Vector4(-0.4247904f, -0.4247904f, -0.7994412f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, -0.1002794f, 0.4247904f, 0),
                 new Vector4(-0.1002794f, 0.8997206f, 0.4247904f, 0),
                 new Vector4(0.4247904f, 0.4247904f, -0.7994412f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, 0.1002794f, -0.4247904f, 0),
                 new Vector4(0.1002794f, 0.8997206f, 0.4247904f, 0),
                 new Vector4(-0.4247904f, 0.4247904f, -0.7994412f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8997206f, 0.1002794f, 0.4247904f, 0),
                 new Vector4(0.1002794f, 0.8997206f, -0.4247904f, 0),
                 new Vector4(0.4247904f, -0.4247904f, -0.7994412f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.05013971f, -0.5250698f, -0.8495809f, 0),
                 new Vector4(-0.5250698f, 0.7374651f, -0.4247904f, 0),
                 new Vector4(-0.8495809f, -0.4247904f, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.05013971f, -0.5250698f, 0.8495809f, 0),
                 new Vector4(-0.5250698f, 0.7374651f, 0.4247904f, 0),
                 new Vector4(0.8495809f, 0.4247904f, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.05013971f, 0.5250698f, -0.8495809f, 0),
                 new Vector4(0.5250698f, 0.7374651f, 0.4247904f, 0),
                 new Vector4(-0.8495809f, 0.4247904f, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.05013971f, 0.5250698f, 0.8495809f, 0),
                 new Vector4(0.5250698f, 0.7374651f, -0.4247904f, 0),
                 new Vector4(0.8495809f, -0.4247904f, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, -0.8495809f, -0.4247904f, 0),
                 new Vector4(-0.8495809f, -0.05013971f, -0.5250698f, 0),
                 new Vector4(-0.4247904f, -0.5250698f, 0.7374651f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, -0.8495809f, 0.4247904f, 0),
                 new Vector4(-0.8495809f, -0.05013971f, 0.5250698f, 0),
                 new Vector4(0.4247904f, 0.5250698f, 0.7374651f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, 0.8495809f, -0.4247904f, 0),
                 new Vector4(0.8495809f, -0.05013971f, 0.5250698f, 0),
                 new Vector4(-0.4247904f, 0.5250698f, 0.7374651f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, 0.8495809f, 0.4247904f, 0),
                 new Vector4(0.8495809f, -0.05013971f, -0.5250698f, 0),
                 new Vector4(0.4247904f, -0.5250698f, 0.7374651f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7374651f, -0.4247904f, -0.5250698f, 0),
                 new Vector4(-0.4247904f, 0.3126746f, -0.8495809f, 0),
                 new Vector4(-0.5250698f, -0.8495809f, -0.05013971f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7374651f, -0.4247904f, 0.5250698f, 0),
                 new Vector4(-0.4247904f, 0.3126746f, 0.8495809f, 0),
                 new Vector4(0.5250698f, 0.8495809f, -0.05013971f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7374651f, 0.4247904f, -0.5250698f, 0),
                 new Vector4(0.4247904f, 0.3126746f, 0.8495809f, 0),
                 new Vector4(-0.5250698f, 0.8495809f, -0.05013971f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7374651f, 0.4247904f, 0.5250698f, 0),
                 new Vector4(0.4247904f, 0.3126746f, -0.8495809f, 0),
                 new Vector4(0.5250698f, -0.8495809f, -0.05013971f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3126746f, -0.9498603f, 0, 0),
                 new Vector4(-0.9498603f, 0.3126746f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3126746f, 0.9498603f, 0, 0),
                 new Vector4(0.9498603f, 0.3126746f, 0, 0),
                 new Vector4(0, 0, 1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.3126746f, -0.9498603f, 0),
                 new Vector4(0, -0.9498603f, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(1, 0, 0, 0),
                 new Vector4(0, -0.3126746f, 0.9498603f, 0),
                 new Vector4(0, 0.9498603f, 0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, 0, -0.9498603f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(-0.9498603f, 0, -0.3126746f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3126746f, 0, 0.9498603f, 0),
                 new Vector4(0, 1, 0, 0),
                 new Vector4(0.9498603f, 0, -0.3126746f, 0),
                 new Vector4(0, 0, 0, 1))
    };
    public static Matrix4x4[] v120_tID_G = new Matrix4x4[60] {
             new Matrix4x4(
                 new Vector4(-1, -0.2676611f, -0.2676611f, 0),
                 new Vector4(-0.2676611f, 0.9641788f, -0.03582123f, 0),
                 new Vector4(-0.2676611f, -0.03582123f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-1, -0.2676611f, 0.2676611f, 0),
                 new Vector4(-0.2676611f, 0.9641788f, 0.03582123f, 0),
                 new Vector4(0.2676611f, 0.03582123f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-1f, 0.2676611f, -0.2676611f, 0),
                 new Vector4(0.2676611f, 0.9641788f, 0.03582123f, 0),
                 new Vector4(-0.2676611f, 0.03582123f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-1, 0.2676611f, 0.2676611f, 0),
                 new Vector4(0.2676611f, 0.9641788f, -0.03582123f, 0),
                 new Vector4(0.2676611f, -0.03582123f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.2676611f, -0.03582123f, 0),
                 new Vector4(-0.2676611f, -1, -0.2676611f, 0),
                 new Vector4(-0.03582123f, -0.2676611f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.2676611f, 0.03582123f, 0),
                 new Vector4(-0.2676611f, -1, 0.2676611f, 0),
                 new Vector4(0.03582123f, 0.2676611f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.2676611f, -0.03582123f, 0),
                 new Vector4(0.2676611f, -1, 0.2676611f, 0),
                 new Vector4(-0.03582123f, 0.2676611f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.2676611f, 0.03582123f, 0),
                 new Vector4(0.2676611f, -1, -0.2676611f, 0),
                 new Vector4(0.03582123f, -0.2676611f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.03582123f, -0.2676611f, 0),
                 new Vector4(-0.03582123f, 0.9641788f, -0.2676611f, 0),
                 new Vector4(-0.2676611f, -0.2676611f, -1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.03582123f, 0.2676611f, 0),
                 new Vector4(-0.03582123f, 0.9641788f, 0.2676611f, 0),
                 new Vector4(0.2676611f, 0.2676611f, -1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.03582123f, -0.2676611f, 0),
                 new Vector4(0.03582123f, 0.9641788f, 0.2676611f, 0),
                 new Vector4(-0.2676611f, 0.2676611f, -1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.03582123f, 0.2676611f, 0),
                 new Vector4(0.03582123f, 0.9641788f, -0.2676611f, 0),
                 new Vector4(0.2676611f, -0.2676611f, -1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6828352f, -0.4910447f, -0.6427858f, 0),
                 new Vector4(-0.4910447f, 0.8567151f, -0.1875624f, 0),
                 new Vector4(-0.6427858f, -0.1875624f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6828352f, -0.4910447f, 0.6427858f, 0),
                 new Vector4(-0.4910447f, 0.8567151f, 0.1875624f, 0),
                 new Vector4(0.6427858f, 0.1875624f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6828352f, 0.4910447f, -0.6427858f, 0),
                 new Vector4(0.4910447f, 0.8567151f, 0.1875624f, 0),
                 new Vector4(-0.6427858f, 0.1875624f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6828352f, 0.4910447f, 0.6427858f, 0),
                 new Vector4(0.4910447f, 0.8567151f, -0.1875624f, 0),
                 new Vector4(0.6427858f, -0.1875624f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, -0.6427858f, -0.1875624f, 0),
                 new Vector4(-0.6427858f, -0.6828352f, -0.4910447f, 0),
                 new Vector4(-0.1875624f, -0.4910447f, 0.8567151f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, -0.6427858f, 0.1875624f, 0),
                 new Vector4(-0.6427858f, -0.6828352f, 0.4910447f, 0),
                 new Vector4(0.1875624f, 0.4910447f, 0.8567151f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, 0.6427858f, -0.1875624f, 0),
                 new Vector4(0.6427858f, -0.6828352f, 0.4910447f, 0),
                 new Vector4(-0.1875624f, 0.4910447f, 0.8567151f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, 0.6427858f, 0.1875624f, 0),
                 new Vector4(0.6427858f, -0.6828352f, -0.4910447f, 0),
                 new Vector4(0.1875624f, -0.4910447f, 0.8567151f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8567151f, -0.1875624f, -0.4910447f, 0),
                 new Vector4(-0.1875624f, 0.7544777f, -0.6427858f, 0),
                 new Vector4(-0.4910447f, -0.6427858f, -0.6828352f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8567151f, -0.1875624f, 0.4910447f, 0),
                 new Vector4(-0.1875624f, 0.7544777f, 0.6427858f, 0),
                 new Vector4(0.4910447f, 0.6427858f, -0.6828352f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8567151f, 0.1875624f, -0.4910447f, 0),
                 new Vector4(0.1875624f, 0.7544777f, 0.6427858f, 0),
                 new Vector4(-0.4910447f, 0.6427858f, -0.6828352f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8567151f, 0.1875624f, 0.4910447f, 0),
                 new Vector4(0.1875624f, 0.7544777f, -0.6427858f, 0),
                 new Vector4(0.4910447f, -0.6427858f, -0.6828352f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3930354f, -0.2233836f, -0.4731341f, 0),
                 new Vector4(-0.2233836f, 0.9641788f, -0.1517412f, 0),
                 new Vector4(-0.4731341f, -0.1517412f, 0.3572142f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3930354f, -0.2233836f, 0.4731341f, 0),
                 new Vector4(-0.2233836f, 0.9641788f, 0.1517412f, 0),
                 new Vector4(0.4731341f, 0.1517412f, 0.3572142f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3930354f, 0.2233836f, -0.4731341f, 0),
                 new Vector4(0.2233836f, 0.9641788f, 0.1517412f, 0),
                 new Vector4(-0.4731341f, 0.1517412f, 0.3572142f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3930354f, 0.2233836f, 0.4731341f, 0),
                 new Vector4(0.2233836f, 0.9641788f, -0.1517412f, 0),
                 new Vector4(0.4731341f, -0.1517412f, 0.3572142f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3572142f, -0.4731341f, -0.1517412f, 0),
                 new Vector4(-0.4731341f, -0.3930354f, -0.2233836f, 0),
                 new Vector4(-0.1517412f, -0.2233836f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3572142f, -0.4731341f, 0.1517412f, 0),
                 new Vector4(-0.4731341f, -0.3930354f, 0.2233836f, 0),
                 new Vector4(0.1517412f, 0.2233836f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3572142f, 0.4731341f, -0.1517412f, 0),
                 new Vector4(0.4731341f, -0.3930354f, 0.2233836f, 0),
                 new Vector4(-0.1517412f, 0.2233836f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3572142f, 0.4731341f, 0.1517412f, 0),
                 new Vector4(0.4731341f, -0.3930354f, -0.2233836f, 0),
                 new Vector4(0.1517412f, -0.2233836f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.1517412f, -0.2233836f, 0),
                 new Vector4(-0.1517412f, 0.3572142f, -0.4731341f, 0),
                 new Vector4(-0.2233836f, -0.4731341f, -0.3930354f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.1517412f, 0.2233836f, 0),
                 new Vector4(-0.1517412f, 0.3572142f, 0.4731341f, 0),
                 new Vector4(0.2233836f, 0.4731341f, -0.3930354f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.1517412f, -0.2233836f, 0),
                 new Vector4(0.1517412f, 0.3572142f, 0.4731341f, 0),
                 new Vector4(-0.2233836f, 0.4731341f, -0.3930354f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.1517412f, 0.2233836f, 0),
                 new Vector4(0.1517412f, 0.3572142f, -0.4731341f, 0),
                 new Vector4(0.2233836f, -0.4731341f, -0.3930354f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.2276117f, -0.7587058f, -0.678607f, 0),
                 new Vector4(-0.7587058f, 0.531094f, -0.4194022f, 0),
                 new Vector4(-0.678607f, -0.4194022f, 0.6248752f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.2276117f, -0.7587058f, 0.678607f, 0),
                 new Vector4(-0.7587058f, 0.531094f, 0.4194022f, 0),
                 new Vector4(0.678607f, 0.4194022f, 0.6248752f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.2276117f, 0.7587058f, -0.678607f, 0),
                 new Vector4(0.7587058f, 0.531094f, 0.4194022f, 0),
                 new Vector4(-0.678607f, 0.4194022f, 0.6248752f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.2276117f, 0.7587058f, 0.678607f, 0),
                 new Vector4(0.7587058f, 0.531094f, -0.4194022f, 0),
                 new Vector4(0.678607f, -0.4194022f, 0.6248752f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6248752f, -0.678607f, -0.4194022f, 0),
                 new Vector4(-0.678607f, -0.2276117f, -0.7587058f, 0),
                 new Vector4(-0.4194022f, -0.7587058f, 0.531094f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6248752f, -0.678607f, 0.4194022f, 0),
                 new Vector4(-0.678607f, -0.2276117f, 0.7587058f, 0),
                 new Vector4(0.4194022f, 0.7587058f, 0.531094f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6248752f, 0.678607f, -0.4194022f, 0),
                 new Vector4(0.678607f, -0.2276117f, 0.7587058f, 0),
                 new Vector4(-0.4194022f, 0.7587058f, 0.531094f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6248752f, 0.678607f, 0.4194022f, 0),
                 new Vector4(0.678607f, -0.2276117f, -0.7587058f, 0),
                 new Vector4(0.4194022f, -0.7587058f, 0.531094f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.531094f, -0.4194022f, -0.7587058f, 0),
                 new Vector4(-0.4194022f, 0.6248752f, -0.678607f, 0),
                 new Vector4(-0.7587058f, -0.678607f, -0.2276117f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.531094f, -0.4194022f, 0.7587058f, 0),
                 new Vector4(-0.4194022f, 0.6248752f, 0.678607f, 0),
                 new Vector4(0.7587058f, 0.678607f, -0.2276117f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.531094f, 0.4194022f, -0.7587058f, 0),
                 new Vector4(0.4194022f, 0.6248752f, 0.678607f, 0),
                 new Vector4(-0.7587058f, 0.678607f, -0.2276117f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.531094f, 0.4194022f, 0.7587058f, 0),
                 new Vector4(0.4194022f, 0.6248752f, -0.678607f, 0),
                 new Vector4(0.7587058f, -0.678607f, -0.2276117f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.01791061f, -0.4910447f, -0.9104469f, 0),
                 new Vector4(-0.4910447f, 0.7544777f, -0.4552235f, 0),
                 new Vector4(-0.9104469f, -0.4552235f, 0.1559693f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.01791061f, -0.4910447f, 0.9104469f, 0),
                 new Vector4(-0.4910447f, 0.7544777f, 0.4552235f, 0),
                 new Vector4(0.9104469f, 0.4552235f, 0.1559693f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.01791061f, 0.4910447f, -0.9104469f, 0),
                 new Vector4(0.4910447f, 0.7544777f, 0.4552235f, 0),
                 new Vector4(-0.9104469f, 0.4552235f, 0.1559693f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.01791061f, 0.4910447f, 0.9104469f, 0),
                 new Vector4(0.4910447f, 0.7544777f, -0.4552235f, 0),
                 new Vector4(0.9104469f, -0.4552235f, 0.1559693f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1559693f, -0.9104469f, -0.4552235f, 0),
                 new Vector4(-0.9104469f, 0.01791061f, -0.4910447f, 0),
                 new Vector4(-0.4552235f, -0.4910447f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1559693f, -0.9104469f, 0.4552235f, 0),
                 new Vector4(-0.9104469f, 0.01791061f, 0.4910447f, 0),
                 new Vector4(0.4552235f, 0.4910447f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1559693f, 0.9104469f, -0.4552235f, 0),
                 new Vector4(0.9104469f, 0.01791061f, 0.4910447f, 0),
                 new Vector4(-0.4552235f, 0.4910447f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1559693f, 0.9104469f, 0.4552235f, 0),
                 new Vector4(0.9104469f, 0.01791061f, -0.4910447f, 0),
                 new Vector4(0.4552235f, -0.4910447f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, -0.4552235f, -0.4910447f, 0),
                 new Vector4(-0.4552235f, 0.1559693f, -0.9104469f, 0),
                 new Vector4(-0.4910447f, -0.9104469f, 0.01791061f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, -0.4552235f, 0.4910447f, 0),
                 new Vector4(-0.4552235f, 0.1559693f, 0.9104469f, 0),
                 new Vector4(0.4910447f, 0.9104469f, 0.01791061f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, 0.4552235f, -0.4910447f, 0),
                 new Vector4(0.4552235f, 0.1559693f, 0.9104469f, 0),
                 new Vector4(-0.4910447f, 0.9104469f, 0.01791061f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, 0.4552235f, 0.4910447f, 0),
                 new Vector4(0.4552235f, 0.1559693f, -0.9104469f, 0),
                 new Vector4(0.4910447f, -0.9104469f, 0.01791061f, 0),
                 new Vector4(0, 0, 0, 1))
    };
    public static Matrix4x4[] v120_tID_J = new Matrix4x4[60] {
             new Matrix4x4(
                 new Vector4(-1, -0.2676611f, -0.2676611f, 0),
                 new Vector4(-0.2676611f, 0.9641788f, -0.03582123f, 0),
                 new Vector4(-0.2676611f, -0.03582123f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-1, -0.2676611f, 0.2676611f, 0),
                 new Vector4(-0.2676611f, 0.9641788f, 0.03582123f, 0),
                 new Vector4(0.2676611f, 0.03582123f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-1, 0.2676611f, -0.2676611f, 0),
                 new Vector4(0.2676611f, 0.9641788f, 0.03582123f, 0),
                 new Vector4(-0.2676611f, 0.03582123f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-1, 0.2676611f, 0.2676611f, 0),
                 new Vector4(0.2676611f, 0.9641788f, -0.03582123f, 0),
                 new Vector4(0.2676611f, -0.03582123f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.2676611f, -0.03582123f, 0),
                 new Vector4(-0.2676611f, -1, -0.2676611f, 0),
                 new Vector4(-0.03582123f, -0.2676611f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.2676611f, 0.03582123f, 0),
                 new Vector4(-0.2676611f, -1, 0.2676611f, 0),
                 new Vector4(0.03582123f, 0.2676611f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.2676611f, -0.03582123f, 0),
                 new Vector4(0.2676611f, -1, 0.2676611f, 0),
                 new Vector4(-0.03582123f, 0.2676611f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.2676611f, 0.03582123f, 0),
                 new Vector4(0.2676611f, -1, -0.2676611f, 0),
                 new Vector4(0.03582123f, -0.2676611f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.03582123f, -0.2676611f, 0),
                 new Vector4(-0.03582123f, 0.9641788f, -0.2676611f, 0),
                 new Vector4(-0.2676611f, -0.2676611f, -1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.03582123f, 0.2676611f, 0),
                 new Vector4(-0.03582123f, 0.9641788f, 0.2676611f, 0),
                 new Vector4(0.2676611f, 0.2676611f, -1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.03582123f, -0.2676611f, 0),
                 new Vector4(0.03582123f, 0.9641788f, 0.2676611f, 0),
                 new Vector4(-0.2676611f, 0.2676611f, -1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.03582123f, 0.2676611f, 0),
                 new Vector4(0.03582123f, 0.9641788f, -0.2676611f, 0),
                 new Vector4(0.2676611f, -0.2676611f, -1, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6828352f, -0.6427858f, -0.4910447f, 0),
                 new Vector4(-0.6427858f, 0.7544777f, -0.1875624f, 0),
                 new Vector4(-0.4910447f, -0.1875624f, 0.8567151f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6828352f, -0.6427858f, 0.4910447f, 0),
                 new Vector4(-0.6427858f, 0.7544777f, 0.1875624f, 0),
                 new Vector4(0.4910447f, 0.1875624f, 0.8567151f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6828352f, 0.6427858f, -0.4910447f, 0),
                 new Vector4(0.6427858f, 0.7544777f, 0.1875624f, 0),
                 new Vector4(-0.4910447f, 0.1875624f, 0.8567151f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.6828352f, 0.6427858f, 0.4910447f, 0),
                 new Vector4(0.6427858f, 0.7544777f, -0.1875624f, 0),
                 new Vector4(0.4910447f, -0.1875624f, 0.8567151f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8567151f, -0.4910447f, -0.1875624f, 0),
                 new Vector4(-0.4910447f, -0.6828352f, -0.6427858f, 0),
                 new Vector4(-0.1875624f, -0.6427858f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8567151f, -0.4910447f, 0.1875624f, 0),
                 new Vector4(-0.4910447f, -0.6828352f, 0.6427858f, 0),
                 new Vector4(0.1875624f, 0.6427858f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8567151f, 0.4910447f, -0.1875624f, 0),
                 new Vector4(0.4910447f, -0.6828352f, 0.6427858f, 0),
                 new Vector4(-0.1875624f, 0.6427858f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.8567151f, 0.4910447f, 0.1875624f, 0),
                 new Vector4(0.4910447f, -0.6828352f, -0.6427858f, 0),
                 new Vector4(0.1875624f, -0.6427858f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, -0.1875624f, -0.6427858f, 0),
                 new Vector4(-0.1875624f, 0.8567151f, -0.4910447f, 0),
                 new Vector4(-0.6427858f, -0.4910447f, -0.6828352f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, -0.1875624f, 0.6427858f, 0),
                 new Vector4(-0.1875624f, 0.8567151f, 0.4910447f, 0),
                 new Vector4(0.6427858f, 0.4910447f, -0.6828352f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, 0.1875624f, -0.6427858f, 0),
                 new Vector4(0.1875624f, 0.8567151f, 0.4910447f, 0),
                 new Vector4(-0.6427858f, 0.4910447f, -0.6828352f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, 0.1875624f, 0.6427858f, 0),
                 new Vector4(0.1875624f, 0.8567151f, -0.4910447f, 0),
                 new Vector4(0.6427858f, -0.4910447f, -0.6828352f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3930354f, -0.4731341f, -0.2233836f, 0),
                 new Vector4(-0.4731341f, 0.3572142f, -0.1517412f, 0),
                 new Vector4(-0.2233836f, -0.1517412f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3930354f, -0.4731341f, 0.2233836f, 0),
                 new Vector4(-0.4731341f, 0.3572142f, 0.1517412f, 0),
                 new Vector4(0.2233836f, 0.1517412f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3930354f, 0.4731341f, -0.2233836f, 0),
                 new Vector4(0.4731341f, 0.3572142f, 0.1517412f, 0),
                 new Vector4(-0.2233836f, 0.1517412f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.3930354f, 0.4731341f, 0.2233836f, 0),
                 new Vector4(0.4731341f, 0.3572142f, -0.1517412f, 0),
                 new Vector4(0.2233836f, -0.1517412f, 0.9641788f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.2233836f, -0.1517412f, 0),
                 new Vector4(-0.2233836f, -0.3930354f, -0.4731341f, 0),
                 new Vector4(-0.1517412f, -0.4731341f, 0.3572142f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, -0.2233836f, 0.1517412f, 0),
                 new Vector4(-0.2233836f, -0.3930354f, 0.4731341f, 0),
                 new Vector4(0.1517412f, 0.4731341f, 0.3572142f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.2233836f, -0.1517412f, 0),
                 new Vector4(0.2233836f, -0.3930354f, 0.4731341f, 0),
                 new Vector4(-0.1517412f, 0.4731341f, 0.3572142f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.9641788f, 0.2233836f, 0.1517412f, 0),
                 new Vector4(0.2233836f, -0.3930354f, -0.4731341f, 0),
                 new Vector4(0.1517412f, -0.4731341f, 0.3572142f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3572142f, -0.1517412f, -0.4731341f, 0),
                 new Vector4(-0.1517412f, 0.9641788f, -0.2233836f, 0),
                 new Vector4(-0.4731341f, -0.2233836f, -0.3930354f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3572142f, -0.1517412f, 0.4731341f, 0),
                 new Vector4(-0.1517412f, 0.9641788f, 0.2233836f, 0),
                 new Vector4(0.4731341f, 0.2233836f, -0.3930354f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3572142f, 0.1517412f, -0.4731341f, 0),
                 new Vector4(0.1517412f, 0.9641788f, 0.2233836f, 0),
                 new Vector4(-0.4731341f, 0.2233836f, -0.3930354f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.3572142f, 0.1517412f, 0.4731341f, 0),
                 new Vector4(0.1517412f, 0.9641788f, -0.2233836f, 0),
                 new Vector4(0.4731341f, -0.2233836f, -0.3930354f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.2276117f, -0.678607f, -0.7587058f, 0),
                 new Vector4(-0.678607f, 0.6248752f, -0.4194022f, 0),
                 new Vector4(-0.7587058f, -0.4194022f, 0.531094f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.2276117f, -0.678607f, 0.7587058f, 0),
                 new Vector4(-0.678607f, 0.6248752f, 0.4194022f, 0),
                 new Vector4(0.7587058f, 0.4194022f, 0.531094f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.2276117f, 0.678607f, -0.7587058f, 0),
                 new Vector4(0.678607f, 0.6248752f, 0.4194022f, 0),
                 new Vector4(-0.7587058f, 0.4194022f, 0.531094f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(-0.2276117f, 0.678607f, 0.7587058f, 0),
                 new Vector4(0.678607f, 0.6248752f, -0.4194022f, 0),
                 new Vector4(0.7587058f, -0.4194022f, 0.531094f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.531094f, -0.7587058f, -0.4194022f, 0),
                 new Vector4(-0.7587058f, -0.2276117f, -0.678607f, 0),
                 new Vector4(-0.4194022f, -0.678607f, 0.6248752f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.531094f, -0.7587058f, 0.4194022f, 0),
                 new Vector4(-0.7587058f, -0.2276117f, 0.678607f, 0),
                 new Vector4(0.4194022f, 0.678607f, 0.6248752f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.531094f, 0.7587058f, -0.4194022f, 0),
                 new Vector4(0.7587058f, -0.2276117f, 0.678607f, 0),
                 new Vector4(-0.4194022f, 0.678607f, 0.6248752f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.531094f, 0.7587058f, 0.4194022f, 0),
                 new Vector4(0.7587058f, -0.2276117f, -0.678607f, 0),
                 new Vector4(0.4194022f, -0.678607f, 0.6248752f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6248752f, -0.4194022f, -0.678607f, 0),
                 new Vector4(-0.4194022f, 0.531094f, -0.7587058f, 0),
                 new Vector4(-0.678607f, -0.7587058f, -0.2276117f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6248752f, -0.4194022f, 0.678607f, 0),
                 new Vector4(-0.4194022f, 0.531094f, 0.7587058f, 0),
                 new Vector4(0.678607f, 0.7587058f, -0.2276117f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6248752f, 0.4194022f, -0.678607f, 0),
                 new Vector4(0.4194022f, 0.531094f, 0.7587058f, 0),
                 new Vector4(-0.678607f, 0.7587058f, -0.2276117f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.6248752f, 0.4194022f, 0.678607f, 0),
                 new Vector4(0.4194022f, 0.531094f, -0.7587058f, 0),
                 new Vector4(0.678607f, -0.7587058f, -0.2276117f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.01791061f, -0.9104469f, -0.4910447f, 0),
                 new Vector4(-0.9104469f, 0.1559693f, -0.4552235f, 0),
                 new Vector4(-0.4910447f, -0.4552235f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.01791061f, -0.9104469f, 0.4910447f, 0),
                 new Vector4(-0.9104469f, 0.1559693f, 0.4552235f, 0),
                 new Vector4(0.4910447f, 0.4552235f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.01791061f, 0.9104469f, -0.4910447f, 0),
                 new Vector4(0.9104469f, 0.1559693f, 0.4552235f, 0),
                 new Vector4(-0.4910447f, 0.4552235f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.01791061f, 0.9104469f, 0.4910447f, 0),
                 new Vector4(0.9104469f, 0.1559693f, -0.4552235f, 0),
                 new Vector4(0.4910447f, -0.4552235f, 0.7544777f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, -0.4910447f, -0.4552235f, 0),
                 new Vector4(-0.4910447f, 0.01791061f, -0.9104469f, 0),
                 new Vector4(-0.4552235f, -0.9104469f, 0.1559693f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, -0.4910447f, 0.4552235f, 0),
                 new Vector4(-0.4910447f, 0.01791061f, 0.9104469f, 0),
                 new Vector4(0.4552235f, 0.9104469f, 0.1559693f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, 0.4910447f, -0.4552235f, 0),
                 new Vector4(0.4910447f, 0.01791061f, 0.9104469f, 0),
                 new Vector4(-0.4552235f, 0.9104469f, 0.1559693f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.7544777f, 0.4910447f, 0.4552235f, 0),
                 new Vector4(0.4910447f, 0.01791061f, -0.9104469f, 0),
                 new Vector4(0.4552235f, -0.9104469f, 0.1559693f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1559693f, -0.4552235f, -0.9104469f, 0),
                 new Vector4(-0.4552235f, 0.7544777f, -0.4910447f, 0),
                 new Vector4(-0.9104469f, -0.4910447f, 0.01791061f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1559693f, -0.4552235f, 0.9104469f, 0),
                 new Vector4(-0.4552235f, 0.7544777f, 0.4910447f, 0),
                 new Vector4(0.9104469f, 0.4910447f, 0.01791061f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1559693f, 0.4552235f, -0.9104469f, 0),
                 new Vector4(0.4552235f, 0.7544777f, 0.4910447f, 0),
                 new Vector4(-0.9104469f, 0.4910447f, 0.01791061f, 0),
                 new Vector4(0, 0, 0, 1)),
             new Matrix4x4(
                 new Vector4(0.1559693f, 0.4552235f, 0.9104469f, 0),
                 new Vector4(0.4552235f, 0.7544777f, -0.4910447f, 0),
                 new Vector4(0.9104469f, -0.4910447f, 0.01791061f, 0),
                 new Vector4(0, 0, 0, 1))
    };
}
