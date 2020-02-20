function JSMethod()
{
    DotNet.invokeMethodAsync('BlazorPrototype', 'JsInvokableMethod');
}


function CallCSharpInstanceMethod(dotnetInstance)
{
    return dotnetInstance.invokeMethodAsync("IncrementCount")
        .then(result => console.log(result));
}