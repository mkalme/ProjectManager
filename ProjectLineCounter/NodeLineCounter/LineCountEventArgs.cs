using System;

namespace ProjectLineCounter {
    public class LineCountEventArgs : EventArgs {
        public int TotalProjects { get; }
        public int CurrentScannedProjects { get; internal set; } = 0;

        public LineCountEventArgs(int totalProjects) {
            TotalProjects = totalProjects;
        }
    }
}
