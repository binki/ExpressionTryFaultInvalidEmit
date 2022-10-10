This repository was created as a reproduction for [SO 73724218](https://stackoverflow.com/questions/73724218).

On .netfx, which compiles expressions to CIL and then JITs them, this program produces a `NotSupportedException` from `System.Reflection.Emit.DynamicILGenerator.BeginFaultBlock()`. That is, the program passes `Expression`’s own validation checks, but it fails at the lower layer which, in my opinion, is a bug in the framework.

On netcore, which uses reflection to execute expression trees, this program succeeds.
