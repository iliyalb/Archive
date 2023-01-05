#include "cuda_runtime.h"
#include "device_launch_parameters.h"
#include <stdio.h>

__global__ void vectorAdd(int *a, int *b, int *c)
{
    // A list of thread called for every index
    int i = threadIdx.x;
    c[i] = a[i] + b[i];
}

int main()
{
    // Locally allocated data on device
    int a[] = {1, 2, 3};
    int b[] = {4, 5, 6};
    int c[sizeof(a) / sizeof(int)] = {0};

    // Declare pointers, allocate GPU memory and copy the vectors
    int *cudaA = 0, cudaB = 0, cudaC = 0;
    cudaMalloc(&cudaA, sizeof(a));
    cudaMalloc(&cudaB, sizeof(b));
    cudaMalloc(&cudaC, sizeof(c));
    cudaMemcpy(cudaA, a, sizeof(a), cudaMemcpyHostToDevice);
    cudaMemcpy(cudaB, b, sizeof(b), cudaMemcpyHostToDevice);

    // Run sizeof many times in parallel and copy out of the GPU
    vectorAdd<<<1, sizeof(a) / sizeof(int)>>>(cudaA, cudaB, cudaC);
    cudaMemcpy(c, cudaC, sizeof(c), cudaMemcpyDeviceToHost);
    return 0;
}
