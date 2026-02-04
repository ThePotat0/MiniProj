#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SaveImageScript : MonoBehaviour
{
    [SerializeField] private Texture2D imageToSave; // Изображение, которое нужно сохранить
    [SerializeField] private Button saveButton; // Кнопка для сохранения изображения

    private void Start()
    {
        saveButton.onClick.AddListener(OnSaveButtonClick);
    }

    private void OnSaveButtonClick()
    {
        string path = GetSavePath();
        if (!string.IsNullOrEmpty(path) && imageToSave != null)
        {
            // Сохранение текстуры в PNG
            byte[] bytes = imageToSave.EncodeToPNG();
            File.WriteAllBytes(path, bytes);
            Debug.Log("Image saved to: " + path);
        }
        else
        {
            Debug.LogError("No image assigned to save or path is invalid.");
        }
    }

    private string GetSavePath()
    {
#if UNITY_EDITOR
        // Открытие диалога выбора файла в редакторе
        string path = EditorUtility.SaveFilePanel("Save Image", "", "Invitation.png", "png");
        return path;
#else
        // Для сборки под другие платформы нужно использовать другие подходы
        Debug.LogError("File dialog is only available in the editor.");
        return null;
#endif
    }
}
