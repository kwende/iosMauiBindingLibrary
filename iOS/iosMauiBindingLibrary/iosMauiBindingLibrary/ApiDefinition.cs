using System;
using Foundation;

namespace Binding
{
    // @interface SwiftLibrary : NSObject
    [BaseType(typeof(NSObject))]
    interface SwiftLibrary
    {
        // -(NSInteger)returnStringWithInput:(NSString * _Nonnull)input __attribute__((warn_unused_result("")));
        [Export("returnStringWithInput:")]
        nint ReturnStringWithInput(string input);
    }
}
