using SharedLib;

namespace Scripts
{
    interface ISaveLoad
    {
        void Save(ProgramData data, string path);

        ProgramData Load(string path);
    }
}
