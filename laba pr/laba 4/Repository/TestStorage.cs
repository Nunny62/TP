using System;
using laba_4.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace laba_4.Repository
{
    public class TestStorage
    {
        private Dictionary<int, Test> Tests { get; } = new Dictionary<int, Test>();

        public void Create(Test test)
        {
            Tests.Add(test.TestID, test);
        }

        public Test Read(int testID)
        {
            return Tests[testID];
        }

        public Test Update(int testID, Test newTest)
        {
            Tests[testID] = newTest;
            return Tests[testID];
        }

        public bool Delete(int testID)
        {
            return Tests.Remove(testID);
        }
    }
}
