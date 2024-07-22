//
//  SwiftLibrary.swift
//  iosMauiSwiftLibrary
//
//  Created by Ocuvera on 7/18/24.
//

import Foundation
import UIKit

@objc(SwiftLibrary)
public class SwiftLibrary : NSObject{
    
    @objc
    public func returnString(input: NSString)->NSString{
        
        // returning a String breaks
        return ("You gave me " + (input as String)) as NSString;
        
        // if you change to return an Int, it works.
        //return 55;
    }
}
