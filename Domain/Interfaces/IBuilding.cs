namespace Domain.Interfaces {
    public interface IBuilding {
        void Print(IFormatter formatter);
        void Print(global::BridgePattern.StandardFormatter formatter);
    }
}