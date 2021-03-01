﻿using UnityEngine.Jobs;
using Unity.Collections;

namespace CodeBase.Logic.JobSystems.Map
{
    public struct MapUpAndDownCubeJob : IJobParallelForTransform
    {
        public NativeArray<UpAndDownCubeJobData> JobData;

        public void Execute(int index, TransformAccess transform)
        {
            while (true)
            {
                UpAndDownCubeJobData cube = JobData[index];
                transform.position = cube.UpdateState(transform.position.y);
                JobData[index] = cube;
            }
        }
    }
}