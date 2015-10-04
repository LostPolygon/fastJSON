namespace fastJSON
{
    /// <summary>
    /// Interface to receive callbacks upon serialization and deserialization.
    /// </summary>
    public interface IJSONSerializationCallbackReceiver
    {
        void OnBeforeSerialize();

        void OnAfterDeserialize();
    }
}
