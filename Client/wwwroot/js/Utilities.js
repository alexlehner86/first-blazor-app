function myFunction(message) {
    console.log('from utilities ', message);
}

function dotNetStaticInvocation() {
    DotNet.invokeMethodAsync("firstBlazorApp.Client", "GetCurrentCount")
        .then(result => console.log(`Count from javascript is ${result}.`));
}

function dotNetInstanceInvocation(dotNetHelper) {
    dotNetHelper.invokeMethodAsync("IncrementCount");
}
