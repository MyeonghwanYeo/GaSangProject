using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR    // Unity Editor 내에서만 컴파일
using UnityEditor;
#endif
using UnityEngine;

public class ExtractMesh : MonoBehaviour
{
    // 모든 자식 GameObject의 메쉬를 추출하는 메서드
#if UNITY_EDITOR    // Unity Editor 내에서만 컴파일
    [ContextMenu("Extract Meshes from Children")]    // Inspector 내에서 바로 호출
    void ExtractMeshesFromChildren()
    {
        // 부모 GameObject의 모든 자식을 순회
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            MeshFilter meshFilter = child.GetComponent<MeshFilter>();

            // 자식에 MeshFilter가 있고 메쉬가 있는지 확인
            if (meshFilter != null && meshFilter.mesh != null)
            {
                string childName = child.name;
                // 자식 이름을 포함한 경로 생성하여 고유한 경로 확보
                string path = $"Assets/Meshes/{childName}.asset";
                string uniquePath = AssetDatabase.GenerateUniqueAssetPath(path);

                Mesh mesh = meshFilter.mesh;

                // 메쉬를 에셋으로 생성
                AssetDatabase.CreateAsset(mesh, uniquePath);
            }
        }
        
        // 모든 에셋을 저장하고 AssetDatabase를 새로고침
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
#endif
}
