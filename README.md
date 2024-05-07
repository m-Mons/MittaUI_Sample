<h1 align="center">MittaUI Sample</h1>

[![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE.md)

UnityにおけるuGUI周りをハッカソンへ向けて行うための基盤を提供するライブラリです。

## 概要
### 本ライブラリの目的
- UnityのデフォルトUIを発展させ、ハッカソン等の短期開発へ大きなバリューを出すことを目的としたUI基盤になります

### 特徴
- 基本的なUI Prefabの構成が派生式となっており、柔軟な変更が可能
- Hoge
- Fuga


## セットアップ
### 要件
* Unity 2022.3 以上
* 動作のためにUniTask, R3が必須

### インストール
MittaUI Sampleでは既に必要なライブラリ「MittaUI」と「MittaUI Service」がインストールされています。


## リポジトリ構成
### MittaUI
- UI基盤を保持するリポジトリ
- ボタンやテキストなど基本的なUIを提供
### MittaUIService
- USNベースで提供されるUIの遷移などを掌るリポジトリ
### MittaUI_Sample
- 「mittaUI」及び「mittaUIService」を用いたUI実装の実例集

## リポジトリ運用
1. Issue&プロジェクトの設計方針&既存実装を確認して、アサインを自分にして作業！
- 新規作成, 提案して作成, 基盤などのリファクタリングを募集
- Issueが立っていない基盤の実装でも、Issueを立てて作業OKです！
2. 完成したらプルリクを出してください！
3. PRレビューしてから、マージ（Approve1以上！）
4. マージされた基盤を用いて、「MittaUI_Sample」へサンプルの実装を行います

## ライセンス
本ソフトウェアはMITライセンスで公開しています。  
ライセンスの範囲内で自由に使っていただけますが、著作権表示とライセンス表示が必須となります。
