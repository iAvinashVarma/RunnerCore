using AV.Middle.Common.HierarchicalData.Interface;
using AV.Middle.Common.Model;
using System;

namespace AV.Middle.Common.HierarchicalData
{
    public class DataProcess : IDataProcess
	{
		IDataProcess _dataProcess = null;

		public DataProcess(IDataProcess dataProcess) => _dataProcess = dataProcess;

		public FileModel FileModel { get => _dataProcess.FileModel; set => _dataProcess.FileModel = value; }

		public HierarchicalDataModel GetHierarchicalDataModel() => _dataProcess.GetHierarchicalDataModel();
	}
}
