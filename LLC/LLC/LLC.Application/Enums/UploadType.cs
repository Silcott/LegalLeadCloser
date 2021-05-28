using System.ComponentModel;

namespace LLC.Application.Enums
{
    public enum UploadType
    {
        [Description(@"Images\Products")]
        Product,

        [Description(@"Images\ProfilePictures")]
        ProfilePicture,

        [Description(@"Documents")]
        Document
    }
}