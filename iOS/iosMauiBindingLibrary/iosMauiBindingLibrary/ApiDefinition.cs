using Foundation;

namespace Binding
{
    // @interface SwiftLibrary : NSObject
    [BaseType(typeof(NSObject))]
    interface SwiftLibrary
    {
        // -(NSString * _Nonnull)returnStringWithInput:(NSString * _Nonnull)input __attribute__((warn_unused_result("")));
        [Export("returnStringWithInput:")]
        string ReturnStringWithInput(string input);
    }
}