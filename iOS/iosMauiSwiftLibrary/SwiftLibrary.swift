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
    public func returnString(input: String)->String{
        
        // returning a String breaks
        return "You gave me " + input;
        
        // if you change to return an Int, it works.
        //return 55;
    }
}
